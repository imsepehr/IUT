USE University;
GO

CREATE VIEW grade_conversion AS
SELECT ID, course_id, sec_id, semester, year,
       CASE grade
           WHEN 'A+' THEN 100
           WHEN 'A'  THEN 95
           WHEN 'A-' THEN 90
           WHEN 'B+' THEN 85
           WHEN 'B'  THEN 80
           WHEN 'B-' THEN 75
           WHEN 'C+' THEN 70
           WHEN 'C'  THEN 65
           WHEN 'C-' THEN 60
           ELSE 0
       END AS numeric_grade
FROM takes;


---a
CREATE VIEW student_gpa AS
SELECT s.ID, s.name, AVG(gc.numeric_grade) AS gpa
FROM student s
JOIN grade_conversion gc ON s.ID = gc.ID
GROUP BY s.ID, s.name;

SELECT * FROM student_gpa;


---b
CREATE VIEW student_instructor_avg_grade AS
SELECT s.ID AS student_id, s.name AS student_name, i.ID AS instructor_id, i.name AS instructor_name,
       AVG(gc.numeric_grade) AS average_grade
FROM student s
JOIN takes t ON s.ID = t.ID
JOIN grade_conversion gc ON t.ID = gc.ID AND t.course_id = gc.course_id AND t.sec_id = gc.sec_id AND t.semester = gc.semester AND t.year = gc.year
JOIN teaches ts ON t.course_id = ts.course_id AND t.sec_id = ts.sec_id AND t.semester = ts.semester AND t.year = ts.year
JOIN instructor i ON ts.ID = i.ID
GROUP BY s.ID, s.name, i.ID, i.name;

SELECT * FROM student_instructor_avg_grade;

