USE Q7;
GO

DELETE FROM STD;
DELETE FROM PRF;
DELETE FROM CRS;
DELETE FROM REG;

CREATE TABLE STD (
    S# INT PRIMARY KEY,
    S_name VARCHAR(100),
    MJR VARCHAR(50),
    Degree VARCHAR(20),
    AGE INT,
    GPA FLOAT
);

CREATE TABLE PRF (
    P# INT PRIMARY KEY,
    P_name VARCHAR(100),
    D# VARCHAR(50)
);

CREATE TABLE CRS (
    C# INT PRIMARY KEY,
    C_name VARCHAR(100),
    term VARCHAR(20),
    Room VARCHAR(20),
    P# INT,
    Time TIME,
    FOREIGN KEY (P#) REFERENCES PRF(P#)
);

CREATE TABLE REG (
    S# INT,
    C# INT,
    PRIMARY KEY (S#, C#),
    FOREIGN KEY (S#) REFERENCES STD(S#),
    FOREIGN KEY (C#) REFERENCES CRS(C#)
);


INSERT INTO STD (S#, S_name, MJR, Degree, AGE, GPA) VALUES
(1, 'Ali', 'ICT', 'Bachelor', 22, 3.4),
(2, 'Sara', 'CS', 'Master', 24, 3.7),
(3, 'Reza', 'ICT', 'PhD', 28, 3.2),
(4, 'Neda', 'Math', 'Bachelor', 21, 3.0),
(5, 'Hossein', 'Physics', 'Bachelor', 23, 2.8),
(6, 'Maryam', 'ICT', 'Bachelor', 25, 3.9);

INSERT INTO PRF (P#, P_name, D#) VALUES
(1, 'Dr. Ahmad Asghari', 'ICT'),
(2, 'Dr. Hossein Falsafain', 'CS');

INSERT INTO CRS (C#, C_name, term, Room, P#, Time) VALUES
(101, 'Math', 'Fall', 'R128', 1, '10:00'),
(102, 'CS', 'Spring', 'R128', 2, '11:00'),
(103, 'ICT', 'Fall', 'R128', 1, '10:00'),
(104, 'Physics', 'Fall', 'R129', 2, '12:00'),
(105, 'Chemistry', 'Spring', 'R130', 1, '10:00');

INSERT INTO REG (S#, C#) VALUES
(1, 101),
(1, 103),
(2, 102),
(3, 103),
(4, 101),
(5, 104),
(6, 101),
(6, 102),
(6, 105);


---a
SELECT MAX(STD.AGE)
FROM STD
WHERE STD.MJR = 'ICT' OR STD.S# IN (
    SELECT REG.S#
    FROM REG
    JOIN CRS ON REG.C# = CRS.C#
    WHERE CRS.P# = 1
);


---b
SELECT CRS.C_name
FROM CRS
WHERE CRS.Room = 'R128' OR CRS.C# IN (
    SELECT REG.C#
    FROM REG
    GROUP BY REG.C#
    HAVING COUNT(*) >= 5
);


---c
SELECT DISTINCT S1.S_name
FROM STD S1
JOIN REG R1 ON S1.S# = R1.S#
JOIN CRS C1 ON R1.C# = C1.C#
JOIN REG R2 ON S1.S# = R2.S# AND R1.C# <> R2.C#
JOIN CRS C2 ON R2.C# = C2.C#
WHERE C1.Time = C2.Time;


---d
SELECT STD.Degree, AVG(STD.AGE) AS Avg_Age
FROM STD
WHERE STD.Degree <> 'PhD'
GROUP BY STD.Degree;


---e
WITH Class_Student_Count AS (
    SELECT REG.C#, COUNT(*) AS Student_Count
    FROM REG
    GROUP BY REG.C#
),
Max_Student_Count AS (
    SELECT MAX(Student_Count) AS Max_Count
    FROM Class_Student_Count
)
SELECT DISTINCT S.S_name
FROM STD S
JOIN REG R ON S.S# = R.S#
JOIN Class_Student_Count CSC ON R.C# = CSC.C#
JOIN Max_Student_Count MSC ON CSC.Student_Count = MSC.Max_Count;


---f
WITH Average_Student_Count AS (
    SELECT AVG(Student_Count) AS Avg_Count
    FROM (
        SELECT COUNT(*) AS Student_Count
        FROM REG
        GROUP BY REG.C#
    ) AS Counts
)
SELECT DISTINCT S.S_name
FROM STD S
JOIN REG R ON S.S# = R.S#
JOIN (
    SELECT REG.C#, COUNT(*) AS Student_Count
    FROM REG
    GROUP BY REG.C#
) AS Class_Student_Count ON R.C# = Class_Student_Count.C#
WHERE Class_Student_Count.Student_Count > (SELECT Avg_Count FROM Average_Student_Count);


---g
INSERT INTO STD (S#, S_name, MJR, Degree, AGE, GPA) VALUES
(7, 'Sepehr', 'ICT', 'Bachelor', 21, 3.75);

SELECT S.S_name
FROM STD S
LEFT JOIN REG R ON S.S# = R.S#
WHERE R.S# IS NULL;


---h
WITH Avg_GPA AS (
    SELECT AVG(GPA) AS Avg_GPA
    FROM STD
)
UPDATE STD
SET GPA = CASE
    WHEN GPA < (SELECT Avg_GPA FROM Avg_GPA) THEN GPA * 1.10
    ELSE GPA * 1.05
END;

SELECT * FROM STD;
