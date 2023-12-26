create table Employee4(Employee_Id int primary key identity,
                       Employee_Name varchar(50),
					   );

create table Emp_Log2(Log_Id int identity(1,1) not null,
                     Employee_Id int not null,
					 Operation varchar(50) not null,
					 UpdatedDate datetime not null
					 );

create trigger t5
on Employee4
after update 
as
insert into Emp_Log2(Employee_Id,Operation,UpdatedDate)
select Employee_Id,'update',GETDATE() from deleted;

insert into Employee4 values('Sayali')
insert into Employee4 values('Prachi')
insert into Employee4 values('Ritu')
update Employee4 set Employee_Name='Purvi' where Employee_Id=3
select * from Employee4
select * from Emp_Log2


