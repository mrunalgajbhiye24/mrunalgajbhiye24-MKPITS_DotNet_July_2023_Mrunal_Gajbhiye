create table Product1(ProductId int primary key,Product_Name varchar(20),Prize int,Quantity int)

insert into Product1 values(1,'Refrigerator',20000,1)
insert into Product1 values(2,'Micowave Oven',25000,1)
insert into Product1 values(3,'TV',60000,3)
insert into Product1 values(4,'Washing Machine',40000,2)

select Product_Name,Prize from Product1 order by Product_Name desc
select top 2 Product_Name,Prize from Product1 order by Product_Name 
select * from Product1