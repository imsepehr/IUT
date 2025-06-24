USE [master]
GO
CREATE LOGIN [SepehrLogin] WITH PASSWORD=N'1', DEFAULT_DATABASE=[master], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
--------------------------
USE [master]

GO

CREATE SERVER ROLE [Role1]

GO
----------------------------

ALTER SERVER ROLE [dbcreator] ADD MEMBER [Role1]

GO


ALTER SERVER ROLE [Role1] ADD MEMBER [SepehrLogin]
GO
-----------------------------------


USE [AdventureWorks2012]
GO
ALTER ROLE [db_datareader] ADD MEMBER [SepehrLogin]
GO
USE [AdventureWorks2012]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [SepehrLogin]
GO
USE [AdventureWorks2012]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [SepehrLogin]
GO



create table Student
(
	firstname varchar(20) not null,
	lastname varchar(20) not null,
	studentNumber char(7) primary key,
);

insert into Student(firstname,lastname,studentNumber) values ('sepehr','ebadi','9933243'),('ali','akbari','9878663')



/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [firstname]
      ,[lastname]
      ,[studentNumber]
  FROM [AdventureWorks2012].[dbo].[Student]


-------------------------------------



USE [AdventureWorks2012]
GO
CREATE ROLE [Role2]
GO
USE [AdventureWorks2012]
GO
ALTER AUTHORIZATION ON SCHEMA::[db_securityadmin] TO [Role2]
GO
USE [AdventureWorks2012]
GO
ALTER ROLE [Role2] ADD MEMBER [SepehrLogin]
GO



USE [AdventureWorks2012]
GO
ALTER AUTHORIZATION ON SCHEMA::[db_datareader] TO [Role2]
GO


