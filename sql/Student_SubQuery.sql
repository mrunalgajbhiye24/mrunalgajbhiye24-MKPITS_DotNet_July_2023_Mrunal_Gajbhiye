create table Student5(Roll_No int,
                      Name varchar(50),
					  Email varchar(150),
					  City varchar(50),
					  Course_Id int
					  );

					  insert into Student5 values(11,'Sayali','sayali123@gmail.com','Nagpur',1),
					                             (22,'Prachi','prachidahi@gmail.com','Mumbai',2),
												 (33,'Sakshi','sakshi@gmail.com','Mumbai',3),
												 (44,'Mayuri','mayu123@gmail.com','Delhi',4),
												 (55,'Ritu','ritu@gmail.com','Nagpur',5),
												 (66,'Jayant','jayant145@gmail.com','Delhi',6),
												 (77,'Chetan','Chetan234@gmail.com','Nagpur',7),
												 (88,'Samruddhi','samruddhi@gmail.com','Delhi',8),
												 (99,'Vidhi','vidhi@gmail.com','Delhi',9)
select * from Student5

create table Fees(Fees_Id int,
                  Roll_No int,
				  Fees_Date date,
				  Amount int,
				  Course_Id int);

				  insert into Fees values(123,11,'2023-12-01',50000,1),
				                         (122,22,'2023-12-02',60000,2),
				                         (134,33,'2023-12-03',60000,3),
				                         (145,44,'2023-12-04',50000,4),
				                         (156,55,'2023-12-05',50000,5),
				                         (157,66,'2023-12-06',60000,6),
				                         (167,77,'2023-12-07',60000,7),
				                         (169,88,'2023-12-08',50000,8),
				                         (170,99,'2023-12-07',60000,9)
select * from Student5
select * from Fees

SELECT Fees_Id,Roll_No,Fees_date,Amount,Course_Id 
FROM Fees 
where Course_Id in(SELECT Course_Id from Student5 where city='Nagpur')

SELECT Fees_Id,Roll_No,Fees_date,Amount,Course_Id 
FROM Fees 
where Course_Id in(SELECT Course_Id from Student5 where city='Mumbai')

SELECT Fees_Id,Roll_No,Fees_date,Amount,Course_Id 
FROM Fees 
where Course_Id in(SELECT Course_Id from Student5 where city='Delhi')