create table fees(RollNo int,Name varchar(20),Course varchar(20),Amount int,Paid_Date date)

insert into fees values(1,'Riya Shah','Java',20000,'2023-11-07')
insert into fees values(2,'Ranjana Shende','Java',20000,'2023-11-09')
insert into fees values(3,'Bhavika Kharat','Dotnet',65000,'2023-07-17')
insert into fees values(4,'Jasmin Sheikh','Dotnet',65000,'2023-07-20')
insert into fees values(5,'Chetan Raut','Java',20000,'2023-11-18')
insert into fees values(6,'Jayant Gohate','Dotnet',65000,'2023-07-02')
insert into fees values(7,'Sakshi Ganvir','Dotnet',65000,'2023-07-09')
insert into fees values(8,'Vidhi Maske','Java',20000,'2023-11-09')
insert into fees values(9,'Ritu Ingole','Dotnet',20000,'2023-08-02')
insert into fees values(10,'Pooja Shende','Java',20000,'2023-11-15')

select * from fees where Paid_date between '2023-11-01' and '2023-11-30'
select * from fees where RollNo in (1,2,3)
select * from fees where Name like '%et%'
select * from fees