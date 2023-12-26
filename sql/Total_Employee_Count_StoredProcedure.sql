create table GetEmployeeCount (Employee_Id int,
                               Employee_Name varchar(50),
					           Designation varchar(50)
							   );

							   insert into GetEmployeeCount values(1,'Sayali','Manager'),
							                                      (2,'Purvi','HR'),
																  (3,'Mayuri','Clerk'),
																  (4,'Rohini','Assistant Manager'),
																  (5,'Chetan','Employee')
select * from GetEmployeeCount
create proc emp2
as
begin
select * from GetEmployeeCount
end
exec emp2
select COUNT(Employee_Id) as 'Total Employee' from GetEmployeeCount

