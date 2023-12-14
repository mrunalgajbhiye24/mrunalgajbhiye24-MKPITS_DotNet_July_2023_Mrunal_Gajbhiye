create table Customers(CustId int, CustName varchar(20),Age int,MobileNo bigint)

insert into Customers values(1,'Moni',20,9867829829)
insert into Customers values(2,'Mayu',22,78885592256)
insert into Customers values(3,'Sakshi',22,9854126665)
insert into Customers values(4,'Sakshi',18,9551557889)
insert into Customers values(5,'Preeti',26,8759456616)
insert into Customers values(6,'Ruhi',23,85455554255)

select distinct CustName from Customers

select * from Customers
drop table Customers