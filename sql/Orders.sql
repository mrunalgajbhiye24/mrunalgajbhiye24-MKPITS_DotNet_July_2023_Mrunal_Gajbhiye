create table Orders(OrderId int,Cust_Name varchar(20),Product_Name varchar(20),Prize bigint,Quantity int,Order_Date date)

insert into Orders values(1,'Monali','Computer',100000,2,'2023-12-14')
insert into Orders values(2,'Anshu','Laptop',80000,2,'2023-08-24')
insert into Orders values(3,'Prcahi','Mouse',700,8,'2023-03-12')
insert into Orders values(4,'Riya','KeyBoard',1000,3,'2023-03-08')
insert into Orders values(5,'Moni','Mouse',700,10,'2023-03-14')

select * from Orders where Order_Date between '2023-02-16' and '2023-08-09'

select * from Orders