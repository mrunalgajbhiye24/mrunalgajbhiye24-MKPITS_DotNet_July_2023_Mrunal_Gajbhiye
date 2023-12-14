create table Students(RollNo int primary key,First_Name varchar(20),Last_Name varchar(20),Course varchar(20))

insert into Students values(1,'Amit','Shah','Dotnet')
insert into Students values(2,'Bhavika','Shende','Java')
insert into Students values(3,'Manish','Jambude','Dotnet')
insert into Students values(4,'Kunal','Shahu','Dotnet')
insert into Students values(5,'Shreya','Sarode','Java')

select First_Name from Students order by First_Name asc
select * from Students