USE [University-Q4];
GO

---a
SELECT i.ID, i.name, COALESCE(COUNT(t.course_id), 0) AS section_count
FROM instructor i
LEFT JOIN teaches t ON i.ID = t.ID
GROUP BY i.ID, i.name
ORDER BY i.ID;


---b
SELECT ID, name
FROM student
WHERE name LIKE 'M%a';


---c
SELECT c.title
FROM course c
JOIN section s ON c.course_id = s.course_id
WHERE c.dept_name LIKE '%Eng.'
  AND s.semester = 'Fall'
  AND s.year = 2009;


  ---d
SELECT s.building, s.room_number
FROM section s
JOIN time_slot t ON s.time_slot_id = t.time_slot_id
WHERE s.semester = 'Spring' AND s.year = 2008
GROUP BY s.building, s.room_number
HAVING SUM(DATEDIFF(HOUR, CAST(t.start_hr AS VARCHAR) + ':' + CAST(t.start_min AS VARCHAR), 
                            CAST(t.end_hr AS VARCHAR) + ':' + CAST(t.end_min AS VARCHAR))) >= 2;

---e
WITH AvgCredits AS (
    SELECT AVG(total_credits) AS avg_credits
    FROM (
        SELECT t.ID, SUM(c.credits) AS total_credits
        FROM takes t
        JOIN course c ON t.course_id = c.course_id
        WHERE t.semester = 'Spring' AND t.year = 2005
        GROUP BY t.ID
    ) AS StudentCredits
),
CSStudents AS (
    SELECT s.ID, s.name, SUM(c.credits) AS total_credits
    FROM student s
    JOIN takes t ON s.ID = t.ID
    JOIN course c ON t.course_id = c.course_id
    WHERE s.dept_name = 'Comp. Sci.' AND t.semester = 'Spring' AND t.year = 2005
    GROUP BY s.ID, s.name
)
SELECT CSStudents.ID, CSStudents.name, CSStudents.total_credits
FROM CSStudents, AvgCredits
WHERE CSStudents.total_credits > AvgCredits.avg_credits;


---f
WITH CS_Courses AS (
    SELECT course_id
    FROM course
    WHERE dept_name = 'Comp. Sci.'
),
CS_Students AS (
    SELECT ID
    FROM student
    WHERE dept_name = 'Comp. Sci.'
),
CS_Student_Courses AS (
    SELECT t.ID, t.course_id
    FROM takes t
    JOIN CS_Students cs ON t.ID = cs.ID
)
SELECT cs.ID, s.name
FROM CS_Students cs
JOIN student s ON cs.ID = s.ID
WHERE NOT EXISTS (
    SELECT 1
    FROM CS_Courses csc
    WHERE NOT EXISTS (
        SELECT 1
        FROM CS_Student_Courses t
        WHERE t.ID = cs.ID AND t.course_id = csc.course_id
    )
);



