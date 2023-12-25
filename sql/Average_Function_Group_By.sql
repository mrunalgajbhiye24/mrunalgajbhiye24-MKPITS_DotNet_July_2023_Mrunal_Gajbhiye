create table Employee_Info2(Employee_Id int,
                           Name varchar(50),
						   Occupation varchar(50),
						   Working_Date date,
						   Working_Hours int,
						   Salary int
						   );

						   insert into Employee_Info2 values(1,'Monali','Manager','2023-10-04',8,90000),
						                                   (2,'Vrushali','HR','2023-10-04',9,65000),
														   (3,'Vidhi','Engineer','2023-10-04',8,95000),
														   (4,'Purvi','Manager','2023-10-04',8,90000),
														   (5,'Darshan','Writer','2023-10-04',8,20000),
						                                   (6,'Prachi','HR','2023-10-04',9,65000)
select * from Employee_Info2


Select Occupation,AVG(Working_Hours) AS "Average Working Hours"
FROM Employee_Info2
GROUP BY Occupation
						                                    
						                                    
						                                    
						                                     