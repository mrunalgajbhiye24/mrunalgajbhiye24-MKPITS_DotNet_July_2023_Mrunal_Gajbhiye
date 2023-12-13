create table Stude(RollNo int primary key,Name varchar(20),Course varchar(20),City varchar(20))

insert into Stude values(1,'Purvi','Java','Nagpur')
insert into Stude values(2,'Navya','Dotnet','Pune')
insert into Stude values(3,'Sakshi','Java','Nagpur')
insert into Stude values(4,'Mahi','Java','Nagpur')
insert into Stude values(5,'Ruhi','Dotnet','Pune')
insert into Stude values(6,'Prachi','Dotnet','Pune')
insert into Stude values(7,'Poo','Java','Nagpur')
insert into Stude values(8,'Riya','Java','Nagpur')
insert into Stude values(9,'Rashi','Dotnet','Pune')
insert into Stude values(10,'Veera','Dotnet','Pune')

select Course,COUNT(*) from Stude where City='Pune' group by Course
select * from Stude