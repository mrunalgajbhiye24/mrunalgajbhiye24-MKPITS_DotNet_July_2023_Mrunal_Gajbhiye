create table Result(Roll_No int  primary key,Name varchar(20),Marks int CHECK(Marks>0))

insert into Result values(1,'Ruhi',99)
insert into Result values(2,'Sayali',82)
insert into Result values(3,'Vaibhav',95)
insert into Result values(4,'Jayant',77)

select * from Result