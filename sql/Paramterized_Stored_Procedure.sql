create table GetEmployeeByDepartment1(Department_Id int,
                                     Employee_Name varchar(50),
									 Department varchar(50)
									 );
									 insert into GetEmployeeByDepartment1 values(1,'Purvi','Mechanical'),
									                                           (2,'Reeta','Electronics'),
																			   (3,'Sayali','Civil'),
																			   (4,'Prachi','IT'),
																			   (5,'Mayuri','CS')
select * from GetEmployeeByDepartment1

create proc dep3 
(@dep_id as int)
as
begin
select * from GetEmployeeByDepartment1
where Department_Id=@dep_id
end;

exec dep3 3
exec dep3 4 
