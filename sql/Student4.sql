create table Student4(RollNo int,First_Name varchar(20),Last_Name varchar(20),Course varchar(20),City varchar(20))

insert into Student4 values(1,'Purvi','Bhoyar','Java','Nagpur')
insert into Student4 values(2,'Navya','Patel','Dotnet','Pune')
insert into Student4 values(3,'Sakshi','Ganvir','Java','Mumbai')
insert into Student4 values(4,'Mahi','Gedam','Java','Nagpur')
insert into Student4 values(5,'Ruhi','Manekar','Dotnet','Pune')
insert into Student4 values(6,'Prachi','Dhaiwale','Dotnet','Pune')
insert into Student4 values(7,'Poo','Tambe','Java','Nagpur')
insert into Student4 values(8,'Riya','Wankhede','Java','Nagpur')
insert into Student4 values(9,'Rashi','Ingole','Dotnet','Mumbai')
insert into Student4 values(10,'Veera','Chauhan','Dotnet','Pune')

select First_Name,COUNT(*) from Student4 where city <> 'Nagpur' group by First_Name order by First_Name
select * from Student4