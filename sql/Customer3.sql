create table Customer3(CustId int ,CustName varchar(20),Gender varchar(20),City varchar(20))

select * from Customer3

insert into Customer3 values(1,'Saki','Female','Nagpur')
insert into Customer3 values(2,'Preeti','Female','Mumbai')
insert into Customer3 values(3,'Chetan','Male','Pune')
insert into Customer3 values(4,'Jayant','Male','Nagpur')
insert into Customer3 values(5,'Savi','Female','Nagpur')
insert into Customer3 values(6,'Prachi','Female','Pune')
insert into Customer3 values(7,'Trish','Female','Mumbai')
insert into Customer3 values(8,'Vaibhav','Male','Pune')
insert into Customer3 values(9,'Amar','Male','Pune')
insert into Customer3 values(10,'Anshul','Male','Mumbai')

select * from Customer3 where City='Pune' order by CustName desc
select * from Customer3 where City='Nagpur' order by CustName desc
