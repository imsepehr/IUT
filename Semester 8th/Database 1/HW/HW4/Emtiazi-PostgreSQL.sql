-------------------------------------------------------------------------2
CREATE OR REPLACE FUNCTION get_actor_films(p_actor_id INT)
RETURNS TABLE (
    film_title TEXT,
    rental_count INT
) AS $$
BEGIN
    RETURN QUERY
    SELECT
        f.title::text AS film_title,
        COUNT(r.rental_id)::int AS rental_count
    FROM
        film f
    JOIN
        film_actor fa ON f.film_id = fa.film_id
    LEFT JOIN
        inventory i ON f.film_id = i.film_id
    LEFT JOIN
        rental r ON i.inventory_id = r.inventory_id
    WHERE
        fa.actor_id = p_actor_id
    GROUP BY
        f.title
    ORDER BY
        rental_count DESC;
END;
$$ LANGUAGE plpgsql;

SELECT * FROM get_actor_films(1);

----------------------------------------------------------------3
CREATE TABLE my_table (
    customer_id INT,
    profit NUMERIC,
    pay_day DATE,
    avg_pay NUMERIC
);


CREATE OR REPLACE PROCEDURE insert_customer_payments(p_first_name TEXT, p_last_name TEXT)
LANGUAGE plpgsql AS $$
DECLARE
    cust_id INT;
    total_payments NUMERIC;
    avg_payment NUMERIC;
    payment RECORD;
BEGIN
    SELECT customer_id INTO cust_id
    FROM customer
    WHERE first_name = p_first_name AND last_name = p_last_name;

    IF cust_id IS NULL THEN
        RAISE EXCEPTION 'Customer not found';
    END IF;

    SELECT AVG(amount) INTO avg_payment
    FROM payment
    WHERE customer_id = cust_id;

    FOR payment IN
        SELECT payment_date, amount
        FROM payment
        WHERE customer_id = cust_id
    LOOP
        INSERT INTO my_table (customer_id, profit, pay_day, avg_pay)
        VALUES (cust_id, payment.amount * 0.10, DATE(payment.payment_date), avg_payment);
    END LOOP;
END;
$$;


CALL insert_customer_payments('Mary', 'Smith');

SELECT * FROM my_table;

----------------------------------------------------------------4
WITH sorted_films AS (
    SELECT
        c.name AS category,
        f.title AS name,
        f.length,
        LAG(f.length) OVER (PARTITION BY c.category_id ORDER BY f.length) AS previous_length,
        LEAD(f.length) OVER (PARTITION BY c.category_id ORDER BY f.length) AS next_length
    FROM
        film f
    JOIN
        film_category fc ON f.film_id = fc.film_id
    JOIN
        category c ON fc.category_id = c.category_id
)
SELECT
    category,
    name,
    length,
    length - COALESCE(previous_length, length) AS per_diff,
    length - COALESCE (next_length, length) AS post_diff
FROM
    sorted_films
ORDER BY
    category,
    length;

----------------------------------------------------------------5
WITH monthly_sales AS (
    SELECT
        EXTRACT(MONTH FROM payment_date) AS month_number,
        f.rating,
        SUM(p.amount) AS sum_amount
    FROM
        payment p
    JOIN
        rental r ON p.rental_id = r.rental_id
    JOIN
        inventory i ON r.inventory_id = i.inventory_id
    JOIN
        film f ON i.film_id = f.film_id
    GROUP BY
        EXTRACT(MONTH FROM payment_date),
        f.rating
),
ordered_sales AS (
    SELECT
        month_number,
        rating,
        sum_amount,
        ROW_NUMBER() OVER (PARTITION BY rating ORDER BY month_number) AS rn
    FROM
        monthly_sales
)
SELECT
    os1.month_number,
    os1.rating,
    os1.sum_amount,
    os2.sum_amount AS prev_month_sales,
    os3.sum_amount AS next_month_sales
FROM
    ordered_sales os1
LEFT JOIN
    ordered_sales os2 ON os1.rating = os2.rating AND os1.rn = os2.rn + 1
LEFT JOIN
    ordered_sales os3 ON os1.rating = os3.rating AND os1.rn = os3.rn - 1
ORDER BY
    os1.month_number,
    os1.rating;

