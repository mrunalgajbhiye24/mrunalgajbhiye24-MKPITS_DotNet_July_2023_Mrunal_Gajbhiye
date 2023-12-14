create table Products(Product_Id int,Product_Name varchar(20),Prize bigint,Quantity int)
insert into Products values(1,'KeyBoard',1000,4)
insert into Products values(2,'Mouse',500,7)
insert into Products values(1,'Computer',70000,4)
insert into Products values(1,'Laptop',60000,4)

select TOP 10 PERCENT Product_Name,Prize from Products Order by Prize desc;

select * from Products