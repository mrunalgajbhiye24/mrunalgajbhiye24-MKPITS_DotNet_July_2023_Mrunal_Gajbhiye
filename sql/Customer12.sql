create table Customers12(Customer_Id int ,
                        Customer_Name varchar(20) not null,
					    Telephone_No bigint);

					insert into Customers12 values(1,'Sakshi',9876543211),
							                     (2,'Sayali',982345678),
							                     (3,'Chetan',7892354352),
											     (4,'Sagar',9453672872),
												 (5,'Prachi',7789979298),
												 (6,'Jayant',8889345678)
select * from Customers12

create table OrdersItem1(Order_Id int,
                        Order_Date date,
						Customer_Id int,
						Product_Name varchar(50) not null,
						Quantity int,
						Rate int);

						insert into OrdersItem1  values(123,'2302-02-09',1,'Keyboard',2,500),
						                              (133,'2023-03-24',4,'Mouse',4,200),
													  (144,'2023-07-15',6,'Desktop',2,10000)
select * from Customers12
select * from OrdersItem1

SELECT Customers12.Customer_Id, Customers12.Customer_Name, Customers12.Telephone_No, OrdersItem.Order_Id,
OrdersItem.Customer_Id,OrdersItem.Product_Name,OrdersItem.Rate
FROM Customers12
LEFT OUTER JOIN  OrdersItem
ON Customers12.Customer_Id = OrdersItem.Customer_Id;
