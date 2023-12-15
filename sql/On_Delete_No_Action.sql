create table Ord1(Order_Id int identity primary key,Order_Date date,Customer_Id int)

create table Orders_Details1(Order_Id int,Product_Name varchar(20),Quantity int,
                            constraint fk7 foreign key(Order_Id) references Ord1(Order_Id) on delete no action)

							insert into Ord1 values('2023-02-09',123)
							insert into Ord1 values('2023-03-09',124)
							insert into Ord1 values('2023-04-09',125)
							insert into Ord1 values('2023-05-09',126)

							insert into Orders_Details1 values(1,'Mouse',2)
							insert into Orders_Details1 values(2,'KeyBoard',2)
							insert into Orders_Details1 values(3,'Computer',1)
							insert into Orders_Details1 values(4,'Laptop',1)

							select * from Ord1

							delete from Orders_Details1 where Order_Id=1
							insert into Orders_Details1 values(1,'CPU',2)

							delete from Ord1 where Order_Id=1
							select * from Orders_Details1