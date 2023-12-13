create table Customer2(CustId int,First_Name varchar(20),Last_Name varchar(20))

select * from Customer2 

insert into Customer2 values(1,'Purvi','Bhoyar')
insert into Customer2 values(2,'Ruhi','Manekar')
insert into Customer2 values(3,'Saki','Patel')
insert into Customer2 values(4,'Preeti','Gajbhiye')
insert into Customer2 values(5,'Ravi','Patil')

select * from Customer2
select * from Customer2 where CustId>1
select * from Customer2 where First_Name='Purvi' and Last_Name='Bhoyar'