create table Employee2(Employee_Id int primary key identity,
                       Employee_Name varchar(50),
					   );

create table Emp_Log(Log_Id int identity(1,1) not null,
                     Employee_Id int not null,
					 Operation varchar(50) not null,
					 UpdatedDate datetime not null
					 );

create trigger t1
on Employee2
for insert 
as
insert into Emp_Log(Employee_Id,Operation,UpdatedDate)
select Employee_Id,'insert',GETDATE() from inserted;

insert into Employee2 values('Sayali')
insert into Employee2 values('Prachi')
insert into Employee2 values('Ritu')
select * from Employee2
select * from Emp_Log


