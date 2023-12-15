create table Ord(Order_Id int identity primary key,Order_Date date,Customer_Id int)

create table Orders_Details(Order_Id int,Product_Name varchar(20),Quantity int,
                            constraint fk4 foreign key(Order_Id) references Ord(Order_Id))

							insert into Ord values('2023-02-09',123)
							insert into Ord values('2023-03-09',124)
							insert into Ord values('2023-04-09',125)
							insert into Ord values('2023-05-09',126)

							insert into Orders_Details values(1,'Mouse',2)
							insert into Orders_Details values(2,'KeyBoard',2)
							insert into Orders_Details values(3,'Computer',1)
							insert into Orders_Details values(4,'Laptop',1)
							select * from Ord
							select * from Orders_Details