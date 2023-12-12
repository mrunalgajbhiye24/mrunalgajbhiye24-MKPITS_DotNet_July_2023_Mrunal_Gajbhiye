create table Employee(EmpId int primary key identity(1,1),EmpName varchar(20))
insert into Employee(EmpName) values('Raj')
insert into Employee(EmpName) values('Rajesh')

delete from Employee where EmpId=1

insert into Employee(EmpName) values ('Mayur')

delete from Employee

insert into Employee(EmpName) values ('Rajesh')
select * from Employee