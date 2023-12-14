create table SalesPeople(SalesMan_Id int,Name varchar(20),City varchar(20),Commission float)

insert into SalesPeople values(1,'Ritu','Nagpur',0.15)
insert into SalesPeople values(2,'Saki','Pune',0.25)
insert into SalesPeople values(3,'Purvi','Bhandara',0.30)
insert into SalesPeople values(4,'Prachi','Bhandara',0.10)
insert into SalesPeople values(5,'Kishori','Gondia',0.20)
insert into SalesPeople values(6,'Chetan','Chandrapur',0.40)
insert into SalesPeople values(7,'Jayant','Nagpur',0.20)
insert into SalesPeople values(8,'Maithili','Gadchiroli',0.15)
insert into SalesPeople values(9,'Trish','Bhandara',0.20)
insert into SalesPeople values(10,'Sayali','Gondia',0.35)

select * from SalesPeople where city='Bhandara'

select * from SalesPeople