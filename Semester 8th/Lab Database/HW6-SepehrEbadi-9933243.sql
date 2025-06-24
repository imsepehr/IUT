/***********************1*************************/
USE [AdventureWorks2012]
GO

/****** Object:  Table [Production].[Product]    Script Date: 4/29/2024 4:31:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [Production].[ProductLogs]
(
	[ProductID] [int]  ,
	[Name] [dbo].[Name]  ,
	[ProductNumber] [nvarchar](25)  ,
	[MakeFlag] [dbo].[Flag]  ,
	[FinishedGoodsFlag] [dbo].[Flag]  ,
	[Color] [nvarchar](15) NULL,
	[SafetyStockLevel] [smallint]  ,
	[ReorderPoint] [smallint]  ,
	[StandardCost] [money]  ,
	[ListPrice] [money]  ,
	[Size] [nvarchar](5) NULL,
	[SizeUnitMeasureCode] [nchar](3) NULL,
	[WeightUnitMeasureCode] [nchar](3) NULL,
	[Weight] [decimal](8, 2) NULL,
	[DaysToManufacture] [int]  NULL,
	[ProductLine] [nchar](2) NULL,
	[Class] [nchar](2) NULL,
	[Style] [nchar](2) NULL,
	[ProductSubcategoryID] [int] NULL,
	[ProductModelID] [int] NULL,
	[SellStartDate] [datetime]  ,
	[SellEndDate] [datetime] NULL,
	[DiscontinuedDate] [datetime] NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL   ,
	[ModifiedDate] [datetime]  ,
	change varchar(10)
)

CREATE TRIGGER ChangesTriggers ON Production.Product
INSTEAD OF INSERT,DELETE ,UPDATE 
AS
BEGIN
DECLARE @type varchar(10)
if EXISTS(SELECT * FROM inserted)
	if EXISTS(SELECT * FROM deleted)
		BEGIN
		SELECT @type = 'update';
		INSERT INTO  [Production].[ProductLogs] SELECT *,@type FROM deleted
		END
	else
		BEGIN
		SELECT @type = 'insert';
		INSERT INTO  [Production].[ProductLogs] SELECT *,@type FROM inserted
		END
else
	if EXISTS (SELECT * FROM deleted)
		BEGIN
		SELECT @type = 'delete'
		INSERT INTO  [Production].[ProductLogs] SELECT *,@type FROM deleted
		END
END

DELETE FROM Production.Product WHERE name='CityBike';

INSERT INTO Production.Product
(
	 Name, ProductNumber, MakeFlag, FinishedGoodsFlag, SafetyStockLevel,
	 ReorderPoint, StandardCost, ListPrice, DaysToManufacture,
	 SellStartDate, RowGUID, ModifiedDate
)
VALUES
(
	 N'CityBike', N'CB-5384', 0, 0, 1000, 750, 0.0000, 0.0000, 0,
	 GETDATE(), NEWID(), GETDATE()
);

SELECT * FROM [Production].[ProductLogs];

/***********************2*************************/
CREATE TABLE [Production].[ProductLogs2]
(
	[ProductID] [int]  ,
	[Name] [dbo].[Name]  ,
	[ProductNumber] [nvarchar](25)  ,
	[MakeFlag] [dbo].[Flag]  ,
	[FinishedGoodsFlag] [dbo].[Flag]  ,
	[Color] [nvarchar](15) NULL,
	[SafetyStockLevel] [smallint]  ,
	[ReorderPoint] [smallint]  ,
	[StandardCost] [money]  ,
	[ListPrice] [money]  ,
	[Size] [nvarchar](5) NULL,
	[SizeUnitMeasureCode] [nchar](3) NULL,
	[WeightUnitMeasureCode] [nchar](3) NULL,
	[Weight] [decimal](8, 2) NULL,
	[DaysToManufacture] [int]  ,
	[ProductLine] [nchar](2) NULL,
	[Class] [nchar](2) NULL,
	[Style] [nchar](2) NULL,
	[ProductSubcategoryID] [int] NULL,
	[ProductModelID] [int] NULL,
	[SellStartDate] [datetime]  ,
	[SellEndDate] [datetime] NULL,
	[DiscontinuedDate] [datetime] NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL   ,
	[ModifiedDate] [datetime]  ,
	change varchar(10)
)

UPDATE [Production].[ProductLogs2]
SET [Name] = 'Bob'
where ProductID =1000;



INSERT INTO [Production].[ProductLogs2]
SELECT * FROM [Production].[ProductLogs];

/***********************3*************************/
CREATE TABLE [Production].[ProductLogs3]
(
	[ProductID] [int]  ,
	[Name] [dbo].[Name]  ,
	[ProductNumber] [nvarchar](25)  ,
	[MakeFlag] [dbo].[Flag]  ,
	[FinishedGoodsFlag] [dbo].[Flag]  ,
	[Color] [nvarchar](15) NULL,
	[SafetyStockLevel] [smallint]  ,
	[ReorderPoint] [smallint]  ,
	[StandardCost] [money]  ,
	[ListPrice] [money]  ,
	[Size] [nvarchar](5) NULL,
	[SizeUnitMeasureCode] [nchar](3) NULL,
	[WeightUnitMeasureCode] [nchar](3) NULL,
	[Weight] [decimal](8, 2) NULL,
	[DaysToManufacture] [int]  ,
	[ProductLine] [nchar](2) NULL,
	[Class] [nchar](2) NULL,
	[Style] [nchar](2) NULL,
	[ProductSubcategoryID] [int] NULL,
	[ProductModelID] [int] NULL,
	[SellStartDate] [datetime]  ,
	[SellEndDate] [datetime] NULL,
	[DiscontinuedDate] [datetime] NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL   ,
	[ModifiedDate] [datetime]  ,
	change varchar(10)
)

DROP PROCEDURE CompareProductLogs

CREATE PROCEDURE CompareProductLogs
AS 
BEGIN
	INSERT INTO [Production].[ProductLogs3] SELECT *
	FROM ((SELECT * FROM [Production].[ProductLogs]) EXCEPT (SELECT * FROM [Production].[ProductLogs2])) temp
	SELECT * FROM [Production].[ProductLogs3]
END
