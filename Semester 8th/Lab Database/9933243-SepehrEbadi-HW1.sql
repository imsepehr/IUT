CREATE TABLE Departments
(
	Name varchar(20) NOT NULL,
	ID char(5) PRIMARY KEY,
	Budget numeric(12,2),
	Category varchar(15) Check (Category in
	('Engineering','Science'))
);


CREATE TABLE Teachers
(
	FirstName varchar(20) NOT NULL,
	LastName varchar(30) NOT NULL,
	ID char(7),
	BirthYear int,
	DepartmentID char(5),
	Salary numeric(7,2) Default 10000.00
	PRIMARY KEY (ID),
	FOREIGN KEY (DepartmentID) REFERENCES  Departments(ID),
);


CREATE TABLE Students
(
	FirstName varchar(20) NOT NULL,
	LastName varchar(30) NOT NULL,
	StudentNumber char(7) PRIMARY KEY,
	BirthYear int,
	DepartmentID char(5),
	AdvisorID char(7),
	FOREIGN KEY (DepartmentID) REFERENCES Departments(ID),
	FOREIGN KEY (AdvisorID) REFERENCES Teachers(ID),
);


ALTER TABLE Students
	ADD Pass int



CREATE TABLE Courses
(
	ID int,
	Title varchar(20),
	Credits int,
	DepartmentID char(5),
	PRIMARY KEY (ID),
	FOREIGN KEY (DepartmentID) REFERENCES Departments(ID),
);


CREATE TABLE Available_Courses
(
	CourseID int,
	Semester  varchar(15) Check (Semester in
		('fall','spring')),
	[YEAR] int,
	ID int,
	TeacherID char(7),
	PRIMARY KEY (ID),
	FOREIGN KEY (TeacherID) REFERENCES Teachers(ID),
	FOREIGN KEY (CourseID) REFERENCES Courses(ID),
);


CREATE TABLE Taken_Courses
(
	StudentID char(7),
	CourseID int,
	Semester  varchar(15) Check (Semester in
		('fall','spring')),
	[Year] int,
	Grade int,
	FOREIGN KEY(CourseID) REFERENCES Courses(ID),
	FOREIGN KEY(StudentID) REFERENCES Students(StudentNumber),
	PRIMARY KEY(StudentID,CourseID,Semester,[Year]),
);


CREATE TABLE Prerequisites
(
	CourseId int,
	PrereqID int,
	PRIMARY KEY(CourseId,PrereqID),
	FOREIGN KEY(CourseId) REFERENCES  Courses(ID),
	FOREIGN KEY(PrereqID) REFERENCES  Courses(ID),
);


/*****************************************************/


INSERT INTO Departments(Name,ID,Budget,Category) VALUES('Network','12345',1000,'Engineering'),('Software','67890',2000,'Science');

INSERT INTO Teachers(FirstName,LastName,ID,BirthYear,DepartmentID,Salary) values ('Mohammad Reza','Heidarpour','1234567',1350,'12345',50000),('Elham','Mahmoudzadeh','1234568',1355,'67890',25000);

INSERT INTO Students(FirstName,LastName,StudentNumber,BirthYear,DepartmentID,AdvisorID,Pass)
VALUES('za','ari','789',78,'12345','1234567',95) , ('Ali','Baei','321',81,'67890','1234568', 52);

INSERT INTO Courses(ID,Title,Credits,DepartmentID) VALUES (1,'Database',3,'12345'),(2,'Algorithm',3,'67890');

INSERT INTO Available_Courses(CourseID,Semester,[Year],ID,TeacherID) VALUES (1,'spring',99,1,'1234567'),(2,'spring',99,2,'1234568');

INSERT INTO Taken_Courses(StudentID,CourseID,Semester,[Year],Grade) values ('789',1,'spring',99,19),('321',2,'spring',99,18);

INSERT INTO Prerequisites(CourseId,PrereqID) values(1,2),(2,1);


/******************************************************/



SELECT Name,ID,Budget,Category
FROM Students INNER JOIN Departments
ON (Students.DepartmentID = Departments.ID)
WHERE (Students.StudentNumber = '789');

SELECT Taken_Courses 
SET Grade  = Grade + 1;

SELECT StudentID
FROM Courses RIGHT JOIN Taken_Courses
ON (Courses.ID = Taken_Courses.CourseID)
WHERE (Courses.Title != 'Database');


