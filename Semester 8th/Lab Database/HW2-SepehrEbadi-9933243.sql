WITH countries As(
SELECT TerritoryID
FROM Sales.SalesTerritory
WHERE Sales.SalesTerritory.[Group] = 'North America'
OR Sales.SalesTerritory.CountryRegionCode = 'FR')
SELECT * FROM Sales.SalesOrderHeader
WHERE TotalDue BETWEEN 100000 AND 500000and STATUS = 5
AND TerritoryID IN (SELECT * FROM countries)




SELECT SalesOrderID, CustomerID, TotalDue, OrderDate, Sales.SalesTerritory.NAME AS OrderPlace
FROM Sales.SalesOrderHeader 
INNER JOIN Sales.SalesTerritory ON
(
  Sales.SalesOrderHeader.TerritoryID = Sales.SalesTerritory.TerritoryID
)



WITH countries AS(
SELECT TerritoryID
FROM Sales.SalesTerritory
WHERE Sales.SalesTerritory.[Group] = 'North America')
SELECT *
INTO NAmerica_Sales
FROM(
      SELECT * FROM Sales.SalesOrderHeader
		  WHERE TotalDue BETWEEN 100000 AND 500000and STATUS = 5 AND TerritoryID IN (SELECT * FROM countries)
    ) AS New_Table

ALTER TABLE NAmerica_Sales
ADD new_column CHAR(4) CHECK(new_column IN ('Low', 'Mid', 'High'));

WITH avgs AS(SELECT avg(TotalDue) AS avrage FROM NAmerica_Sales)
UPDATE NAmerica_Sales
SET new_column = CASE
WHEN TotalDue > (SELECT * FROM avgs) THEN 'High'
WHEN TotalDue < (SELECT * FROM avgs) THEN 'Low'
else 'Mid'
END


SELECT BusinessEntityID, (CASE  ntile(4) OVER (ORDER BY max(Rate) ASC)
WHEN 1 THEN  max(Rate) * 1.2
WHEN 2 THEN  max(Rate) * 1.15
WHEN 3 THEN  max(Rate) * 1.1
WHEN 4 THEN  max(Rate) * 1.05
END )
  AS updated_salary,
(
CASE
WHEN max(Rate) BETWEEN 29 AND 50 THEN '2'
WHEN max(Rate) < 29 THEN '3'
ELSE '1'
END
)  AS LEVEL
FROM HumanResources.EmployeePayHistory
GROUP BY BusinessEntityID
ORDER BY BusinessEntityID