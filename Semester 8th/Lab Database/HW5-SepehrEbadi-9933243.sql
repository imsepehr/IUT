USE AdventureWorks2012
GO
/*1*/
select * from Sales.SalesOrderDetail


SELECT [Name], [Europe], [North America], [Pacific]
FROM 
(
	SELECT p.[name], st.[Group], p.[ProductID]
	FROM Sales.SalesOrderDetail AS sod
	INNER JOIN Sales.SalesOrderHeader soh ON sod.SalesOrderID = soh.SalesOrderID
	INNER JOIN Production.Product AS p ON p.ProductID = sod.ProductID
	INNER JOIN Sales.SalesTerritory AS st ON soh.TerritoryID = st.TerritoryID
) AS SourceTable
PIVOT
(
	COUNT([ProductID])
	FOR [Group] IN ([North America], [Europe], [Pacific])
)	AS PVT


/*2*/

select Person.BusinessEntityID, PersonType, Gender
from Person.Person join HumanResources.Employee on (Person.BusinessEntityID = Employee.BusinessEntityID)


SELECT PersonType, [M], [F]
FROM 
(
	SELECT Person.BusinessEntityID, PersonType, Gender
	FROM Person.Person JOIN HumanResources.Employee ON (Person.BusinessEntityID =
	Employee.BusinessEntityID)
)AS SourceTable
PIVOT
(
	COUNT(BusinessEntityID)
	FOR Gender IN ([M], [F])
)AS PVT

/*3*/
SELECT p.Name
FROM Production.Product AS p
WHERE LEN(p.Name) < 15 AND SUBSTRING(p.Name, LEN(p.Name)-1,1) = 'e'

/*4*/

IF OBJECT_ID (N'dbo.myFunc', N'FN') IS NOT NULL     
DROP FUNCTION dbo.myFunc; 
GO 
CREATE FUNCTION dbo.myFunc(@word nvarchar(10)) 
RETURNS nvarchar(255) 
AS  
BEGIN
	DECLARE @result nvarchar(255);     
	DECLARE @ret nvarchar(255);   
	DECLARE @month nvarchar(30);    
	DECLARE @year nvarchar(20)
	IF NOT (@word like '____/__/__' and len(@word) = 10
	and ISNUMERIC(SUBSTRING(@word, 1, 4)) =1
	and ISNUMERIC(SUBSTRING(@word, 6, 2)) =1
	and ISNUMERIC(SUBSTRING(@word, 9, 2)) =1) BEGIN
		SET @ret = N'اشتباه است'; 
	RETURN @ret;
	END;
	SET @month = CASE SUBSTRING(@word, 6, 2)
		WHEN '01' then CONCAT ( SUBSTRING(@word, len(@word)-2, 2),N'فروردین ماه')
		WHEN '02' then CONCAT ( SUBSTRING(@word, len(@word)-1, 2),N'اردیبهشت ماه')
		WHEN '03' then CONCAT ( SUBSTRING(@word, len(@word)-1, 2),N'خرداد ماه')
		WHEN '04' then CONCAT ( SUBSTRING(@word, len(@word)-1, 2),N'تیر ماه')
		WHEN '05' then CONCAT ( SUBSTRING(@word, len(@word)-1, 2),N'مرداد ماه')
		WHEN '06' then CONCAT ( SUBSTRING(@word, len(@word)-1, 2),N'شهریور ماه')
		WHEN '07' then CONCAT ( SUBSTRING(@word, len(@word)-1, 2),N'مهر ماه')
		WHEN '08' then CONCAT ( SUBSTRING(@word, len(@word)-1, 2),N'آبان ماه')
		WHEN '09' then CONCAT ( SUBSTRING(@word, len(@word)-1, 2),N'آذر ماه')
		WHEN '10' then CONCAT ( SUBSTRING(@word, len(@word)-1, 2),N'دی ماه')
		WHEN '11' then CONCAT ( SUBSTRING(@word, len(@word)-1, 2),N'بهمن ماه')
		WHEN '12' then CONCAT ( SUBSTRING(@word, len(@word)-1, 2),N'اسفند ماه')
		END;
	SET @year = SUBSTRING(@word, 1, 4)
	SET @result =@month +@year+  N' شمسی ';
	RETURN @result;
END; 

SELECT dbo.myFunc('1380/11/20')
SELECT dbo.myFunc('13000/4/02')


/*5*/

IF OBJECT_ID (N'dbo.func', N'IF') IS NOT NULL
DROP FUNCTION func;
GO
CREATE FUNCTION dbo.func(@year int, @month int, @name varchar(50))
RETURNS TABLE
AS
RETURN
(
SELECT distinct st.[Group] FROM
Production.product as p join
Sales.SalesOrderDetail as sd on(sd.ProductID = p.ProductID) join
Sales.SalesOrderHeader as sh on(sh.SalesOrderID = sd.SalesOrderID) join
Sales.SalesTerritory as st on(st.TerritoryID = sh.TerritoryID)
where year(sh.orderDate) = @year and month(sh.orderDate) = @month and @name= p.Name
);
GO

SELECT * FROM dbo.func(2005,07,'Mountain-100 Black, 42')