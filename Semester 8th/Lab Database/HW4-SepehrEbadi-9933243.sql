/*1*/
USE AdventureWorks2012
GO
SELECT Sales.SalesOrderHeader.OrderDate, Sales.SalesOrderDetail.LineTotal,
AVG(Sales.SalesOrderDetail.LineTotal)OVER (PARTITION BY Sales.SalesOrderHeader.CustomerID
ORDER BY Sales.SalesOrderHeader.OrderDate, Sales.SalesOrderHeader.SalesOrderID
ROWS BETWEEN 2 PRECEDING AND CURRENT ROW)
FROM Sales.SalesOrderHeader JOIN Sales.SalesOrderDetail ON
(SalesOrderDetail.SalesOrderID = SalesOrderHeader.SalesOrderID)
/*2*/
SELECT 
CASE GROUPING (SalesTerritory.name)
WHEN 0 THEN SalesTerritory.name
WHEN 1 THEN 'All Teritories'
END AS tername,
CASE GROUPING (SalesTerritory."group")
WHEN 0 THEN SalesTerritory."group"
WHEN 1 THEN 'All Regions'
END AS region,
SUM(SalesOrderHeader.subtotal) AS "sum",
COUNT(*) AS "count"
FROM sales.SalesTerritory AS SalesTerritory,sales.SalesOrderHeader AS SalesOrderHeader
WHERE (SalesTerritory.TerritoryID = SalesOrderHeader.TerritoryID)
GROUP BY ROLLUP(SalesTerritory."group",SalesTerritory.name)
/*3*/
SELECT SUM(sod.LineTotal) Sum_Total, COUNT(distinct sod.salesorderid) AS Total_Count, CASE GROUPING(pc.name)
WHEN 0 THEN pc.name
WHEN 1 THEN 'All Categories'
END AS Teritory_Name, CASE GROUPING(psc.name)
WHEN 0 THEN psc.name
WHEN 1 THEN 'All Sub-Categories'
END AS Region
FROM Production.ProductSubcategory AS psc, 
	production.ProductCategory AS pc,
	production.Product AS pr,
	sales.SalesOrderDetail AS sod
WHERE pc.ProductCategoryID = psc.ProductCategoryID and
      sod.ProductID = pr.ProductID and 
      pr.ProductSubcategoryID = psc.ProductSubcategoryID
GROUP BY GROUPING SETS((),pc.name, (pc.name, psc.name))
/*4*/
WITH template(FirstName, NationalIDNumber, gender, ms, job, con) AS 
(
SELECT FirstName, NationalIDNumber, gender,
CASE
	WHEN emp.MaritalStatus = 'M' THEN 'Marital'
	WHEN emp.MaritalStatus = 'S'  THEN 'Single'
END AS ms, JobTitle, COUNT(*) OVER (PARTITION BY emp.jobtitle)
FROM HumanResources.Employee AS emp join person.person AS pr ON (emp.BusinessEntityID = pr.BusinessEntityID)
)

SELECT * 
FROM template
WHERE template.con > 3


