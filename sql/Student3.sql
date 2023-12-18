create table Student3(RollNo int, Name varchar(20))

select * from Student3

insert into Student3 values(1,'Purvi')
insert into Student3 values(2,'Ruhi')
insert into Student3 values(3,'Sayali')
insert into Student3 values(4,'Purvi')

select * from Student3 where RollNo>3
select * from Student3 where Name='Purvi'