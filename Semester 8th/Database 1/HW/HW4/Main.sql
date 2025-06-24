USE [Database-HW4]
GO

----------------------------------------------------------------1
---a
ALTER TABLE section
ADD numa numeric;

---b
UPDATE section
SET numa = (
    SELECT COUNT(*)
    FROM takes
    WHERE takes.course_id = section.course_id
      AND takes.sec_id = section.sec_id
      AND takes.semester = section.semester
      AND takes.year = section.year
      AND takes.grade IN ('A', 'A+', 'A-')
)
WHERE EXISTS (
    SELECT 1
    FROM takes
    WHERE takes.course_id = section.course_id
      AND takes.sec_id = section.sec_id
      AND takes.semester = section.semester
      AND takes.year = section.year
      AND takes.grade IN ('A', 'A+', 'A-')
);

---show output
SELECT course_id,sec_id,semester,year, numa
FROM section
ORDER BY numa DESC

---c
CREATE TRIGGER update_numa_trigger
ON takes
AFTER INSERT, UPDATE
AS
BEGIN
    IF UPDATE(grade)
    BEGIN
        DECLARE @course_id varchar(8), @sec_id varchar(8), @semester varchar(6), @year numeric(4,0);
        SELECT @course_id = course_id, @sec_id = sec_id, @semester = semester, @year = year
        FROM inserted;
        
        UPDATE section
        SET numa = (
            SELECT COUNT(*)
            FROM takes
            WHERE takes.course_id = @course_id
              AND takes.sec_id = @sec_id
              AND takes.semester = @semester
              AND takes.year = @year
              AND grade IN ('A', 'A+', 'A-')
        )
        WHERE section.course_id = @course_id
          AND section.sec_id = @sec_id
          AND section.semester = @semester
          AND section.year = @year;
    END
END;

---update a record in takes to test trigger
UPDATE takes
SET grade = 'A'
WHERE ID = '1000'
  AND course_id = '239'
  AND sec_id = '1'
  AND semester = 'Fall'
  AND year = 2006;


SELECT numa
FROM section
WHERE course_id = '239'
  AND sec_id = '1'
  AND semester = 'Fall'
  AND year = 2006;


  ---d
  WITH course_a_count AS (
    SELECT c.course_id, c.dept_name, COUNT(t.grade) AS a_count
    FROM course c
    JOIN takes t ON c.course_id = t.course_id
    WHERE t.grade IN ('A', 'A+', 'A-')
    GROUP BY c.course_id, c.dept_name
),
ranked_courses AS (
    SELECT course_id, dept_name, a_count,
           NTILE(4) OVER (PARTITION BY dept_name ORDER BY a_count DESC) AS quartile
    FROM course_a_count
)
SELECT TOP 10 course_id, quartile
FROM ranked_courses
ORDER BY course_id;

----------------------------------------------------------------6
CREATE TABLE Y (
    Day INT PRIMARY KEY,
    Age INT,
    Weight FLOAT
);

-----
DECLARE @Day INT = 1;
DECLARE @Age INT = 1;
DECLARE @Weight FLOAT = 2.0;

WHILE @Day <= 70
BEGIN
    INSERT INTO Y (Day, Age, Weight) VALUES (@Day, @Age, @Weight);
    SET @Day = @Day + 1;
    SET @Age = @Age + 1;
    SET @Weight = @Weight + (RAND() * 1.0);
END;
---------

WITH WeeklyWeight AS (
    SELECT
        CEILING(Day / 7.0) AS Week,
        MIN(Weight) AS StartWeight,
        MAX(Weight) AS EndWeight
    FROM Y
    GROUP BY CEILING(Day / 7.0)
),
WeightIncrease AS (
    SELECT
        Week,
        ((EndWeight - StartWeight) / StartWeight) * 100 AS PercentIncrease
    FROM WeeklyWeight
)
SELECT TOP 1
    Week,
    PercentIncrease
FROM WeightIncrease
ORDER BY PercentIncrease DESC;


----------------------------------------------------------------7
CREATE TABLE [dbo].[Customer_trn](
[VoucherId] [varchar](21) NULL,
[TrnDate] [date] NULL,
[TrnTime] [varchar](6) NULL,
[Amount] [bigint] NULL,
[CustomerID] [int] NULL)

INSERT INTO [dbo].[Customer_trn] ([VoucherId], [TrnDate], [TrnTime], [Amount], [CustomerID])
VALUES
('V001', '2024-01-01', '120000', 1500, 1),
('V002', '2024-01-02', '130000', 2000, 1),
('V003', '2024-01-03', '140000', 2500, 1),
('V004', '2024-01-01', '090000', 3000, 2),
('V005', '2024-01-02', '100000', 3500, 2),
('V006', '2024-01-03', '110000', 4000, 2),
('V007', '2024-01-04', '150000', 4500, 2),
('V008', '2024-01-01', '080000', 5000, 3),
('V009', '2024-01-02', '090000', 5500, 3),
('V010', '2024-01-03', '100000', 6000, 3),
('V011', '2024-01-04', '110000', 6500, 3),
('V012', '2024-01-05', '120000', 7000, 3),
('V013', '2024-01-06', '130000', 7500, 3);

--------
WITH CustomerTransactionCount AS (
    SELECT 
        CustomerID, 
        COUNT(*) AS Voucher_Count
    FROM 
        Customer_trn
    GROUP BY 
        CustomerID
),
RankedTransactions AS (
    SELECT 
        ct.CustomerID,
        ct.Voucher_Count,
        t.VoucherId,
        t.TrnDate,
        t.TrnTime,
        t.Amount,
        ROW_NUMBER() OVER (PARTITION BY t.CustomerID ORDER BY t.TrnDate, t.TrnTime) AS Counter
    FROM 
        Customer_trn t
    JOIN 
        CustomerTransactionCount ct ON t.CustomerID = ct.CustomerID
)
SELECT 
    Voucher_Count,
    Counter,
    VoucherId,
    TrnDate,
    TrnTime,
    Amount,
    CustomerID
FROM 
    RankedTransactions
ORDER BY 
    Voucher_Count DESC,
    CustomerID,
    Counter;

----------------------------------------------------------------8
CREATE TABLE Table1 (
    id INT,
    num INT
);

INSERT INTO Table1 (id, num) VALUES
(1, 1),
(2, 1),
(3, 1),
(4, 2),
(5, 1),
(6, 2),
(7, 2);

WITH ConsecutiveNums AS (
    SELECT 
        num,
        COUNT(*) OVER (PARTITION BY num, grp) AS consecutive_count
    FROM (
        SELECT 
            *,
            ROW_NUMBER() OVER (ORDER BY id) - ROW_NUMBER() OVER (PARTITION BY num ORDER BY id) AS grp
        FROM Table1
    ) AS sub
)
SELECT DISTINCT
    num AS ConsecutiveNums
FROM 
    ConsecutiveNums
WHERE 
    consecutive_count >= 3;



----------------------------------------------------------------9
CREATE TABLE MyTable (
    Id INT,
    Visit_Date DATE,
    People INT
);

INSERT INTO MyTable (Id, Visit_Date, People) VALUES
(1, '2017-01-01', 10),
(2, '2017-01-02', 109),
(3, '2017-01-03', 150),
(4, '2017-01-04', 99),
(5, '2017-01-05', 145),
(6, '2017-01-06', 1455),
(7, '2017-01-07', 199),
(8, '2017-01-09', 188);

-----------
WITH FilteredData AS (
    SELECT 
        Id, 
        Visit_Date, 
        People, 
        ROW_NUMBER() OVER (ORDER BY Id) AS RowNum,
        Id - ROW_NUMBER() OVER (ORDER BY Id) AS GroupId
    FROM 
        MyTable
    WHERE 
        People >= 100
),
GroupedData AS (
    SELECT 
        GroupId, 
        COUNT(*) AS GroupCount
    FROM 
        FilteredData
    GROUP BY 
        GroupId
    HAVING 
        COUNT(*) >= 3
)
SELECT 
    f.Id, 
    f.Visit_Date, 
    f.People
FROM 
    FilteredData f
JOIN 
    GroupedData g ON f.GroupId = g.GroupId
ORDER BY 
    f.Id;




----------------------------------------------------------------10
CREATE TABLE dpst_trn (
    dpst_num INT,
    trns_time DATETIME,
    dpst_trnover DECIMAL(10, 2)
);

INSERT INTO dpst_trn (dpst_num, trns_time, dpst_trnover) VALUES
(1022, '2018-06-15 14:00', 100),
(1022, '2018-06-15 14:28', -50),
(1022, '2018-06-17 14:58', 25),
(1067, '2019-07-18 23:32', 300);

CREATE TABLE dpst_trn_bal (
    dpst_num INT,
    trns_time DATETIME,
    dpst_trnover DECIMAL(10, 2),
    balance DECIMAL(10, 2)
);

CREATE PROCEDURE UpdateDpstTrnBal
AS
BEGIN
    DECLARE @lastProcessedTime DATETIME;
    SELECT @lastProcessedTime = MAX(trns_time) FROM dpst_trn_bal;
    IF @lastProcessedTime IS NULL
    BEGIN
        SELECT @lastProcessedTime = MIN(trns_time) FROM dpst_trn;
    END
    
    ;WITH NextDayTransactions AS (
        SELECT *
        FROM dpst_trn
        WHERE CAST(trns_time AS DATE) = DATEADD(DAY, 1, CAST(@lastProcessedTime AS DATE))
    )
    INSERT INTO dpst_trn_bal (dpst_num, trns_time, dpst_trnover, balance)
    SELECT 
        nt.dpst_num,
        nt.trns_time,
        nt.dpst_trnover,
        ISNULL((SELECT TOP 1 balance FROM dpst_trn_bal WHERE dpst_num = nt.dpst_num ORDER BY trns_time DESC), 0) + nt.dpst_trnover AS balance
    FROM 
        NextDayTransactions nt
    ORDER BY 
        nt.trns_time;

END;

EXEC UpdateDpstTrnBal;

SELECT * FROM dpst_trn_bal;


