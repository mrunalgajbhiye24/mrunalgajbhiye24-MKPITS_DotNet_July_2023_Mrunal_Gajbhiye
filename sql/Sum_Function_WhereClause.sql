create table Employee_Info4(Employee_Id int,
                           Name varchar(50),
						   Occupation varchar(50),
						   Working_Date date,
						   Working_Hours int,
						   Salary int
						   );

						   insert into Employee_Info4 values(1,'Monali','Manager','2023-10-04',8,90000),
						                                   (2,'Vrushali','HR','2023-10-04',9,65000),
														   (3,'Vidhi','Engineer','2023-10-04',8,95000),
														   (4,'Purvi','Manager','2023-10-04',9,90000),
														   (5,'Darshan','Writer','2023-10-04',8,20000),
						                                   (6,'Prachi','HR','2023-10-04',8,65000)
select * from Employee_Info4
drop table Employee_Info4

Select SUM(Salary) AS "Total Salary"
FROM Employee_Info4
Where Working_Hours>8

						                                    
						                                    
						                                    
						                                     