create table Student6(Roll_No int,
                      Name varchar(50),
					  Email varchar(150),
					  City varchar(50),
					  Course_Id int
					  );

					  insert into Student6 values(11,'Sayali','sayali123@gmail.com','Nagpur',1),
					                             (22,'Prachi','prachidahi@gmail.com','Mumbai',2),
												 (33,'Sakshi','sakshi@gmail.com','Mumbai',3),
												 (44,'Mayuri','mayu123@gmail.com','Delhi',4),
												 (55,'Ritu','ritu@gmail.com','Nagpur',5),
												 (66,'Jayant','jayant145@gmail.com','Delhi',6),
												 (77,'Chetan','Chetan234@gmail.com','Nagpur',7),
												 (88,'Samruddhi','samruddhi@gmail.com','Delhi',8),
												 (99,'Vidhi','vidhi@gmail.com','Delhi',9)
select * from Student6

create table Course(Course_Id int,
                  Roll_No int,
				  Course_Name varchar(50),
				  Fees_Date date,
				  fees int,
				  duration varchar(50));

				  insert into Course values(1,11,'Java','2023-12-01',50000,'4 Months'),
				                         (2,22,'Dotnet','2023-12-02',60000,'6 Months'),
				                         (3,33,'php','2023-12-03',65000,'3 Months'),
				                         (4,44,'Java','2023-12-04',50000,'4 Months'),
				                         (5,55,'Dotnet','2023-12-05',50000,'6 Months'),
				                         (6,66,'php','2023-12-06',65000,'3 Months'),
				                         (7,77,'Java','2023-12-07',60000,'4 Months'),
				                         (8,88,'Dotnet','2023-12-08',50000,'6 Months'),
				                         (9,99,'php','2023-12-07',60000,'3 Months')
select * from Student6
select * from Course

SELECT Course_Id,Roll_No,Course_Name,Fees_date,fees,duration 
FROM Course
where Course_Id in(SELECT Course_Id from Student6 where Course_Name='Java')

SELECT Course_Id,Roll_No,Course_Name,Fees_date,fees,duration 
FROM Course
where Course_Id in(SELECT Course_Id from Student6 where Course_Name='Dotnet')


SELECT Course_Id,Roll_No,Course_Name,Fees_date,fees,duration 
FROM Course
where Course_Id in(SELECT Course_Id from Student6 where Course_Name='php')
