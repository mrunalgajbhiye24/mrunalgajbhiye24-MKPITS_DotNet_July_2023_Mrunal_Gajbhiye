create table Orders3(Order_No int,Purchase_Amt int,Order_Date date,Customer_Id int)

insert into Orders3 values(1,200,'2023-02-04',123)
insert into Orders3 values(2,500,'2023-03-11',123)
insert into Orders3 values(3,900,'2023-04-09',123)
insert into Orders3 values(4,300,'2023-01-21',123)
insert into Orders3 values(5,700,'2023-11-25',123)

select Order_No,Purchase_Amt,Order_Date from Orders3 order by Order_No
select * from Orders3