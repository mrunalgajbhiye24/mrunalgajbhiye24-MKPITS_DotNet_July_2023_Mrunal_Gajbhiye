create table InsertEmployee(Employee_Id int,
                            Employee_Name varchar(50),
							Designation varchar(50),
							Salary int
							);

							insert into InsertEmployee values(11,'Rohini','Manager',90000),
									                         (22,'Purvi','HR',60000),
													         (33,'Rohit','Clerk',20000),
															 (44,'Mayuri','Project Manager',50000),
															 (55,'Ravi','Peon',10000),
															 (66,'Sakshi','Manager',90000),
															 (77,'Raghvi','HR',60000),
															 (88,'Sakshi','Peon',10000)
select * from InsertEmployee

create proc emp5
as
begin 
select * from InsertEmployee
insert into InsertEmployee values(99,'Sahil','HR',60000)
end;
exec emp5

select DISTINCT(Employee_Name) from InsertEmployee