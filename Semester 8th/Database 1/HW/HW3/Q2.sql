USE University;
GO

---a
ALTER TABLE student
ADD total_credits numeric(3, 0) DEFAULT 0;

UPDATE student
SET total_credits = (
    SELECT SUM(c.credits)
    FROM takes t
    JOIN course c ON t.course_id = c.course_id
    WHERE t.ID = student.ID
);

---b
UPDATE takes
SET grade = CASE
    WHEN grade = 'A-' THEN 'A'
    WHEN grade = 'B+' THEN 'A-'
    WHEN grade = 'B' THEN 'B+'
    WHEN grade = 'B-' THEN 'B'
    WHEN grade = 'C+' THEN 'B-'
    WHEN grade = 'C' THEN 'C+'
    WHEN grade = 'C-' THEN 'C'
    WHEN grade = 'D+' THEN 'C-'
    WHEN grade = 'D' THEN 'D+'
    WHEN grade = 'F' THEN 'D'
    ELSE grade
END;

---c
ALTER TABLE takes
ADD CONSTRAINT chk_grade
CHECK (grade IN ('A+','A', 'A-', 'B+', 'B', 'B-', 'C+', 'C', 'C-', 'D+', 'D','D-', 'F'));

---d
ALTER TABLE takes
ADD numeric_grade varchar(255);

UPDATE takes
SET numeric_grade = grade;

---e
UPDATE takes
SET numeric_grade = CASE
	WHEN grade = 'A+' THEN '100'
    WHEN grade = 'A' THEN '95'
    WHEN grade = 'A-' THEN '90'
    WHEN grade = 'B+' THEN '85'
    WHEN grade = 'B' THEN '80'
    WHEN grade = 'B-' THEN '75'
    WHEN grade = 'C+' THEN '70'
    WHEN grade = 'C' THEN '65'
    WHEN grade = 'C-' THEN '60'
    WHEN grade = 'D+' THEN '55'
    WHEN grade = 'D' THEN '50'
	WHEN grade = 'D-' THEN '45'
    WHEN grade = 'F' THEN '40'
    ELSE numeric_grade
END;


---f
DELETE FROM student
WHERE ID IN (
    SELECT DISTINCT ID
    FROM takes
    WHERE grade = 'F'
);


