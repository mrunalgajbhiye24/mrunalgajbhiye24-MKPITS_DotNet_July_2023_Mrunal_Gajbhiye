create table SalesMans(SalesMan_Id int,Name varchar(20),City varchar(20),Commission float)

insert into SalesMans values(1,'Ritu','Nagpur',0.15)
insert into SalesMans values(2,'Saki','Pune',0.25)
insert into SalesMans values(3,'Purvi','Bhandara',0.30)
insert into SalesMans values(4,'Prcahi','Bhandara',0.10)
insert into SalesMans values(5,'Kishori','Gondia',0.20)
insert into SalesMans values(6,'Chetan','Chandrapur',0.40)
insert into SalesMans values(7,'Jayant','Nagpur',0.20)
insert into SalesMans values(8,'Maithili','Gadchiroli',0.15)
insert into SalesMans values(9,'Trsih','Bhandara',0.20)
insert into SalesMans values(10,'Sayali','Gondia',0.35)

select Name,Commission from SalesMans order by Name desc

select * from SalesMans