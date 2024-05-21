

Create database SchoolSysDB



use SchoolSysDB

Create Table Class(
ClassId int Primary key identity(1,1) not null,
ClassName varchar(50) null);

Create Table Subject(
SubjectId int Primary key identity(1,1) not null,
ClassId int foreign key references Class (ClassId) null,
SubjectName varchar(50) null);

Create Table Student(
StudentId int Primary key identity(1,1) not null,
Name varchar(50) null,
DOB date null,
Gender varchar(50) null,
Mobile bigint null,
RollNo varchar null,
Address varchar(max) null,
ClassId int foreign key references Class (ClassId) null);

Create Table Teacher(
TeacherId int Primary key identity(1,1) not null,
Name varchar(50) null,
DOB date null,
Gender varchar(50) null,
Mobile bigint null,
Email varchar null,
Address varchar(max) null,
Password varchar(50) null
);

Create Table TeacherSubject(
Id int Primary key identity(1,1) not null,
ClassId int foreign key references Class (ClassId) null ,
SubjectId int foreign key references Subject (SubjectId) null,
TeacherId int foreign key references Teacher (TeacherId) null);


Create Table TeacherAttendance(
Id int Primary key identity(1,1) not null,
TeacherId int foreign key references Teacher (TeacherId) null,
Status  bit  null,
Date date null)

Create Table StudentAttendance(
Id int Primary key identity(1,1) not null,
ClassId int foreign key references Class (ClassId) null ,
SubjectId int foreign key references Subject (SubjectId) null,
RollNo varchar(20) null,
Status  bit  null,
Date date null)

Create Table Fees(
feesId int Primary key identity(1,1) not null,
ClassId int foreign key references Class (ClassId) null ,
FeesAmount int null
)

Create Table Exam(
ExamId int Primary key identity(1,1) not null,
ClassId int foreign key references Class (ClassId) null ,
SubjectId int foreign key references Subject (SubjectId) null,
RollNo varchar(20) null,
TotalMarks int null,
OutOfMarks int null)

Create Table Expense(
ExpenseId int Primary key identity(1,1) not null,
ClassId int foreign key references Class (ClassId) null ,
SubjectId int foreign key references Subject (SubjectId) null,
ChargeAmount int null)




























