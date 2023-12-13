create table Emp(EmpID int primary key identity(1,1),EmpName varchar(20),Designation varchar(20),Salary int)

insert into Emp(EmpName,Designation,Salary) values('Prachi','Manager',10000)
insert into Emp(EmpName,Designation,Salary) values('Riya','HR',8000)
insert into Emp(EmpName,Designation,Salary) values('Purvi','Mentor',9000)
insert into Emp(EmpName,Designation,Salary) values('Aditi','Manager',10000)
insert into Emp(EmpName,Designation,Salary) values('Rohini','Mentor',5000)
insert into Emp(EmpName,Designation,Salary) values('Saki','Clerk',1000)
insert into Emp(EmpName,Designation,Salary) values('Bhavika','HR',6000)
insert into Emp(EmpName,Designation,Salary) values('Payal','Peon',500)
insert into Emp(EmpName,Designation,Salary) values('Gauravi','Mentor',5000)
insert into Emp(EmpName,Designation,Salary) values('Ravi','Peon',500)

select Designation,COUNT(*) from Emp where Designation='Mentor' group by Designation
select * from Emp