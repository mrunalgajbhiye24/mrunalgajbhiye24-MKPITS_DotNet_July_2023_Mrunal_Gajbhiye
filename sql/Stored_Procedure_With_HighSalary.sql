create table GetHighSalaryEmployees(Employee_Id int,
                                    Employee_Name varchar(50),
									Designation varchar(50),
									Salary int
									);

									insert into GetHighSalaryEmployees values(11,'Rohini','Manager',90000),
									                                         (22,'Purvi','HR',60000),
																			 (33,'Rohit','Clerk',20000),
																			 (44,'Mayuri','Project Manager',50000),
																			 (55,'Ravi','Peon',10000)
select * from  GetHighSalaryEmployees

create proc highsal
(@sal as int)
as
begin 
select * from GetHighSalaryEmployees
where Salary>@sal
end;

exec highsal 20000
