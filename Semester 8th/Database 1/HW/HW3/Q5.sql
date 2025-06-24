
CREATE TABLE transactions (
    id INT PRIMARY KEY,
    person VARCHAR(50),
    Address VARCHAR(50)
);


INSERT INTO transactions (id, person, Address) VALUES
(1, 'bob', NULL),
(2, 'bob', NULL),
(3, 'jim', NULL),
(4, 'bob', 'A'),
(5, 'bob', NULL),
(6, 'bob', 'B'),
(7, 'jim', 'X'),
(8, 'jim', 'Y'),
(9, 'jim', NULL);


WITH AddressUpdate AS (
    SELECT 
        id, 
        person, 
        Address,
        LAST_VALUE(Address) OVER (PARTITION BY person ORDER BY id ROWS BETWEEN UNBOUNDED PRECEDING AND CURRENT ROW) AS Address2
    FROM 
        transactions
)
SELECT 
    id, 
    person, 
    Address,
    CASE 
        WHEN Address IS NULL THEN LAG(Address2) OVER (PARTITION BY person ORDER BY id)
        ELSE Address2
    END AS Address2
FROM 
    AddressUpdate
ORDER BY 
    id;



