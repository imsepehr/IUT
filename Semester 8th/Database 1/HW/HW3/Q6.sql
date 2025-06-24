USE TEMP;
GO 

delete from CTRN;
drop table CTRN;

CREATE TABLE CUSTOMER (
    CID INT PRIMARY KEY
);

CREATE TABLE CTRN (
    CID INT,
    Time VARCHAR(20), 
    Amount DECIMAL(18, 2)
);

INSERT INTO CUSTOMER (CID) VALUES (1234), (5678);

INSERT INTO CTRN (CID, Time, Amount) VALUES
(1234, '1402-04-24', 1700000), 
(1234, '1402-05-29', 1000000), 
(1234, '1402-06-19', 1200000), 
(1234, '1402-07-13', 1900000), 
(1234, '1402-08-04', 1300000), 
(1234, '1402-09-28', 1700000), 
(5678, '1402-04-14', 1800000), 
(5678, '1402-05-21', 1100000), 
(5678, '1402-06-24', 1300000), 
(5678, '1402-07-22', 1800000), 
(5678, '1402-08-09', 1400000), 
(5678, '1402-09-20', 1600000); 


WITH Transactions AS (
    SELECT
        CID,
        Amount,
        Time
    FROM
        CTRN
    WHERE
        SUBSTRING(Time,1,4) = '1402'
        AND CAST(SUBSTRING(Time,6,2) AS INT) BETWEEN 7 AND 12
),
MonthlyTotals AS (
    SELECT
        CID,
        CAST(SUBSTRING(Time,6,2) AS INT) AS Month,
        SUM(Amount) AS TotalAmount
    FROM
        CTRN
    WHERE
        SUBSTRING(Time,1,4) = '1402'
        AND CAST(SUBSTRING(Time,6,2) AS INT) BETWEEN 7 AND 12
    GROUP BY
        CID,
        CAST(SUBSTRING(Time,6,2) AS INT)
)
SELECT
    p.CID,
    ISNULL(p.[7], 0) AS Month7,
    ISNULL(p.[8], 0) AS Month8,
    ISNULL(p.[9], 0) AS Month9,
    ISNULL(p.[10], 0) AS Month10,
    ISNULL(p.[11], 0) AS Month11,
    ISNULL(p.[12], 0) AS Month12,
    GREATEST(
        ISNULL(p.[7], 0),
        ISNULL(p.[8], 0),
        ISNULL(p.[9], 0),
        ISNULL(p.[10], 0),
        ISNULL(p.[11], 0),
        ISNULL(p.[12], 0)
    ) AS Max
FROM
    MonthlyTotals
PIVOT (
    SUM(TotalAmount)
    FOR Month IN ([7], [8], [9], [10], [11], [12])
) AS p;

