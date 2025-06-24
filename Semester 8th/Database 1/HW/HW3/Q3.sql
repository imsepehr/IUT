USE University;
GO


---a
SELECT DISTINCT s1.name
FROM student s1
INNER JOIN student s2 ON s1.name = s2.name AND s1.ID <> s2.ID;

---b
WHERE LEFT(first_name, 2) = 'me' AND RIGHT(last_name, 3) = 'avi';

---c
SELECT *
FROM student s
WHERE EXISTS (
    SELECT 1
    FROM takes t
    WHERE t.ID = s.ID
);


---d
SELECT *
FROM student
UNION
SELECT *
FROM takes
WHERE ID NOT IN (SELECT ID FROM student)
UNION
SELECT *
FROM student
WHERE ID NOT IN (SELECT ID FROM takes);



