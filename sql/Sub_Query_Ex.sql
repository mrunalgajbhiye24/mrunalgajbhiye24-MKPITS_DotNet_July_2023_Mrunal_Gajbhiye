create table Customers14(Customer_Id int,
                         Customer_Name varchar(20),
						 State varchar(50),
						 City varchar(50)
						 );

						 insert into Customers14 values(1,'Sayali','Maharashtra','Nagpur'),
						                               (2,'Prachi','Madhya Pradesh','Bhopal'),
													   (3,'Sakshi','Gujarat','Surat'),
													   (4,'Vaibhav','Maharashtra','Nagpur'),
													   (5,'Shubham','Madhya Pradesh','Bhopal')

select * from Customers14

create table Orders6(Order_Id int,
                     Customer_Id int,
					 Order_date date,
					 Product_Name varchar(50),
					 Quantity int
					 );

					 insert into Orders6 values(11,1,'2023-01-09','TV',1),
					                           (22,2,'2023-02-15','Desktop',2),
											   (33,3,'2023-04-02','Mouse',3),
											   (44,4,'2023-12-25','Keyboard',2),
					                           (55,5,'2023-11-20','Laptop',1)
select * from Customers14
select * from Orders6
select Customer_Id from Customers14 where City='Nagpur'

SELECT Order_Id,Customer_Id,Order_date,Product_Name 
FROM Orders6 
where Customer_Id in(SELECT Customer_Id from Customers14 where city='Bhopal')
ORDER BY Order_date desc

													   