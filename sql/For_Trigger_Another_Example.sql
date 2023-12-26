create table Employee3(Employee_Id int identity primary key,
                       First_Name varchar(20),
                       Last_Name varchar(20),
					   Email varchar(50),
					   Phone bigint,
					   Hire_Date date,
					   Manager_Id int,
					   Salary int,
					   Department_Id int
					   );

create table Emp_Log1(Log_Id int,
                      Employee_Id int,
					  Operation varchar(50),
					  Updated_Date datetime
					  );

create trigger t2
on Employee3
for insert
as
insert into Emp_Log1(Employee_Id,Operation,Updated_Date)
Select Employee_Id,'insert',GETDATE()
from inserted

insert into Employee3(First_Name,Last_Name,Email,Phone,Hire_Date,Manager_Id,Salary,Department_Id) values('Sayali','Kapse','sayali@gmail.com',9876543211,'2023-10-01',11,90000,111),
                                                                                                         ('Prachi','Patil','prachi@gmail.com',8876543211,'2023-10-02',22,6000,222),
																										 ('Aditi','Zade','aditi@gmail.com',9876563222,'2023-10-03',33,40000,333),
																										 ('Ruhi','Manekar','ruhi@gmail.com',7776543211,'2023-10-04',44,50000,444),
																										 ('Purvi','Bhoyar','purvi@gmail.com',9876555211,'2023-10-05',55,80000,555)
select * from Employee3
select * from Emp_Log1

