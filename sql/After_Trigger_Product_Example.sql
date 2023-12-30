create table Products15(Product_Id int,
                       Product_Name varchar(50),
					   Stock_Quantity int,
					   Price int
					   );
create table Product_log(
                         Product_Id int not null,
					     Operation varchar(50) not null,
					     UpdatedDate datetime not null
					    );
create trigger UpdateInventory
on Products15
after update 
as
insert into Product_log(Product_Id,Operation,UpdatedDate)
Select Product_Id,'update',GETDATE() from deleted;

insert into Products15 values(11,'Refrigerator',1,20000)
insert into Products15 values(22,'Computer',2,70000)
insert into Products15 values(33,'Microwave Owen',3,25000)
insert into Products15 values(44,'Washing Machine',2,20000)
update Products15 set Stock_Quantity=4 where Product_Name='Refrigerator'
select * from Products15
select * from Product_log