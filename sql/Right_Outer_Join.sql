create table StudentDetails2(Id int primary key identity,
                            Admission_No int,
					        First_Name varchar(50) not null,
							Last_Name varchar(50) not null,
							age int,
							City varchar(50)
							);

							insert into StudentDetails2 values(123,'Purvi','Bhoyar',22,'Nagpur'),
							                                 (134,'Monali','Shende',25,'Bhandara'),
							                                 (145,'Sakshi','Ganvir',20,'Chandrapur'),
							                                 (156,'Ruhi','Manekar',26,'Mumbai'),
															 (166,'Sayali','Kapse',22,'Nagpur'),
															 (177,'Chetan','Raut',25,'Amravati'),
															 (188,'Jayant','Gohate',22,'Nagpur')
select * from StudentDetails2 

create table Stud_Fees2(Admission_No int,
                       Course varchar(50) not null,
					   Amount_Paid int not null);

					   insert into Stud_Fees2 values(123,'Java',20000),
					                               (188,'Dotnet',65000),
												   (145,'Dotnet',65000),
												   (166,'Java',20000)
												   
select * from StudentDetails2
select * from Stud_Fees2

SELECT StudentDetails2.Admission_No, StudentDetails2.First_Name, StudentDetails2.Last_Name, Stud_Fees2.Course, Stud_Fees2.Amount_Paid  
FROM StudentDetails2  
RIGHT OUTER JOIN Stud_Fees2
ON StudentDetails2.Admission_No = Stud_Fees2.Admission_No;
