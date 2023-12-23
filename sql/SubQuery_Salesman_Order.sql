create table Salesman(Salesman_Id  int,
                        Customer_Name varchar(50),
						City varchar(50),
						Comission decimal,						
						);

						insert into Salesman values(1,'Monu','Nagpur',15),
						                             (2,'Sonali','Bhandara',20),
													 (3,'Chetan','Nagpur',10),
													 (4,'Jayant','Chandrapur',25),
													 (5,'Sayali','Nagpur',30),
													 (6,'Prachi','Bhandara',20),
													 (7,'Reetu','Chanrapur',15),
													 (8,'Sakshi','Bhandara',25)
select * from Salesman
drop table Salesman

create table Orders7(Order_No int,
                     Purchase_Amount int,
					 Order_Date date,
					 Customer_Id int,
					 Salesman_Id int,
					 );

					 insert into Orders7 values(11,300,'2023-11-01',111,1),
					                           (22,400,'2023-11-02',222,2),
											   (33,500,'2023-11-03',333,3),
											   (44,600,'2023-11-04',444,4),
											   (55,700,'2023-11-05',555,5),
											   (66,800,'2023-11-06',666,6),
											   (77,900,'2023-11-07',777,7),
											   (88,1000,'2023-11-08',888,8)
select * from Salesman
select * from Orders7

SELECT Order_No , Purchase_Amount ,Order_Date ,Customer_Id ,Salesman_Id  FROM Orders7
WHERE Salesman_Id in (SELECT Salesman_Id 
FROM Salesman 
WHERE Customer_Name='Jayant')
