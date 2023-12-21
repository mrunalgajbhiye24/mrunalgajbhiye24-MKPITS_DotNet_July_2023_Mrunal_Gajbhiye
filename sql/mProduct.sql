create table mProduct(Product_Name varchar(50),Price int)

insert into mProduct values('Refrigerator',40000)
insert into mProduct values('Washing Machine',25000)
insert into mProduct values('MicroWave Owen',50000)
insert into mProduct values('TV',20000)

update mProduct set Price=50000
where Product_Name='TV'

update mProduct set Price=15000
where Product_Name='Refrigerator'
select * from mProduct

delete from mProduct where Product_Name='MicroWave Owen'
delete from mProduct
select * from mProduct

truncate table mProduct
insert into mProduct values('Mouse',200)
insert into mProduct values('Keyboard',500)
insert into mProduct values('Desktop',1000)
select * from mProduct