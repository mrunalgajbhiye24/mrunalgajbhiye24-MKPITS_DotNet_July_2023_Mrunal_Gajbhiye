create table StudentDetails4(Id int primary key identity,
                            Admission_No int,
					        First_Name varchar(50) not null,
							Last_Name varchar(50) not null,
							age int,
							City varchar(50)
							);

							insert into StudentDetails4 values(123,'Purvi','Bhoyar',22,'Nagpur'),
							                                 (134,'Monali','Shende',25,'Bhandara'),
							                                 (145,'Sakshi','Ganvir',20,'Chandrapur'),
							                                 (156,'Ruhi','Manekar',26,'Mumbai'),
															 (166,'Sayali','Kapse',22,'Nagpur'),
															 (177,'Chetan','Raut',25,'Amravati'),
															 (188,'Jayant','Gohate',22,'Nagpur')
select * from StudentDetails4

create table Stud_Fees4(Admission_No int,
                       Course varchar(50) not null,
					   Amount_Paid int not null);

					   insert into Stud_Fees4 values(123,'Java',20000),
					                               (188,'Dotnet',65000),
												   (145,'Dotnet',65000),
												   (166,'Java',20000)
												   
select * from StudentDetails4
select * from Stud_Fees4

select s1.First_Name,s1.Last_Name,s2.City
     from StudentDetails4 s1,StudentDetails4 s2
     where s1.Id <> s2.Id 
     and s1.City=s2.City
     order by s2.City

