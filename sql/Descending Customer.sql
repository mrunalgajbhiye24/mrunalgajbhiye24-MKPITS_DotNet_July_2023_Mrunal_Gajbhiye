create table Customer1(CustId int primary key, CustName varchar(20))

select * from Customer1

insert into Customer1 values(1,'Purvi')
insert into Customer1 values(2,'Rohini')
insert into Customer1 values(3,'Sayli')
insert into Customer1 values(4,'Prachi')
insert into Customer1 values(5,'Aditi')
select * from Customer1 order by CustId desc
select * from Customer1 order by CustName desc

drop table Customer1