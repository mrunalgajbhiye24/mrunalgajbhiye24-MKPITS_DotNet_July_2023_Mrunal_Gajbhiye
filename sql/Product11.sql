create table Product11(Product_Name varchar(50),Price int)

insert into Product11 values('Refrigerator',40000)
insert into Product11 values('Washing Machine',25000)
insert into Product11 values('MicroWave Owen',50000)
insert into Product11 values('TV',20000)

update Product11 set Price=50000
where Product_Name='TV'

update Product11 set Price=15000
where Product_Name='Refrigerator'

delete from Product11 where Product_Name='MicroWave Owen'

insert into Product11 values('Keyboard',500)
select * from Product11