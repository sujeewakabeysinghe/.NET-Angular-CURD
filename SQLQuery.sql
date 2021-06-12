create database EmployeeDB

create table Departments (
DepartmentID bigint identity(1,1) not null,
DepartmentName varchar(1000)
)

select * from Departments

select DepartmentID, DepartmentName from Departments

insert into Departments values (
'IT'
)

create table Employees (
EmloyeeID bigint identity(1,1) not null,
EmployeeName varchar(1000),
Department varchar(1000),
EmployeeMail varchar(1000),
DateOfJoined date
)

select * from Employees

select EmloyeeID, EmployeeName, Department, EmployeeMail, convert(varchar(10), DateOfJoined, 120) as DateOfJoined from Employees

insert into Employees values (
'Jack',
'Finance',
'jack@gmail.com',
'5-12-2020'
);

delete from Employees where EmployeeName = 'Jack' and Department='Finance';
