create table StudentDetails3(Id int primary key identity,
                            Admission_No int,
					        First_Name varchar(50) not null,
							Last_Name varchar(50) not null,
							age int,
							City varchar(50)
							);

							insert into StudentDetails3 values(123,'Purvi','Bhoyar',22,'Nagpur'),
							                                 (134,'Monali','Shende',25,'Bhandara'),
							                                 (145,'Sakshi','Ganvir',20,'Chandrapur'),
							                                 (156,'Ruhi','Manekar',26,'Mumbai'),
															 (166,'Sayali','Kapse',22,'Nagpur'),
															 (177,'Chetan','Raut',25,'Amravati'),
															 (188,'Jayant','Gohate',22,'Nagpur')
select * from StudentDetails3

create table Stud_Fees3(Admission_No int,
                       Course varchar(50) not null,
					   Amount_Paid int not null);

					   insert into Stud_Fees3 values(123,'Java',20000),
					                               (188,'Dotnet',65000),
												   (145,'Dotnet',65000),
												   (166,'Java',20000)
												   
select * from StudentDetails3
select * from Stud_Fees3

SELECT StudentDetails3.Admission_No, StudentDetails3.First_Name, StudentDetails3.Last_Name, Stud_Fees3.Course, Stud_Fees3.Amount_Paid  
FROM StudentDetails3  
FULL OUTER JOIN Stud_Fees3
ON StudentDetails3.Admission_No = Stud_Fees3.Admission_No;
