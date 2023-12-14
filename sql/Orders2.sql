create table Orders2(Customer_Id int,Order_No int,Purchase_Amt int,Order_Date date)

insert into Orders2 values(1,123,500,'2023-01-09')
insert into Orders2 values(2,234,1000,'2023-02-18')
insert into Orders2 values(3,678,500,'2023-04-30')
insert into Orders2 values(5,567,200,'2023-06-17')
insert into Orders2 values(6,908,500,'2023-10-05')

select distinct Purchase_Amt from Orders2
select * from Orders2