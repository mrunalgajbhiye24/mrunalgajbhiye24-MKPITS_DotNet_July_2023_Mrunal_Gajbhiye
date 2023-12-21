create table StudentDetails(Id int primary key identity,
                            Admission_No int,
					        First_Name varchar(50) not null,
							Last_Name varchar(50) not null,
							age int,
							City varchar(50)
							);

							insert into StudentDetails values(123,'Purvi','Bhoyar',22,'Nagpur'),
							                                 (134,'Monali','Shende',25,'Bhandara'),
							                                 (145,'Sakshi','Ganvir',20,'Chandrapur'),
							                                 (156,'Ruhi','Manekar',26,'Mumbai'),
															 (166,'Sayali','Kapse',22,'Nagpur'),
															 (177,'Chetan','Raut',25,'Amravati'),
															 (188,'Jayant','Gohate',22,'Nagpur')
select * from StudentDetails 

create table Stud_Fees(Admission_No int,
                       Course varchar(50) not null,
					   Amount_Paid int not null);

					   insert into Stud_Fees values(123,'Java',20000),
					                               (188,'Dotnet',65000),
												   (145,'Dotnet',65000),
												   (166,'Java',20000)
select * from StudentDetails 
select * from Stud_Fees

SELECT StudentDetails.Admission_No, StudentDetails.First_Name, StudentDetails.Last_Name, Stud_Fees.Course, Stud_Fees.Amount_Paid  
FROM StudentDetails  
INNER JOIN Stud_Fees  
ON StudentDetails.Admission_No = Stud_Fees.Admission_No;
drop table StudentDetails
drop table Stud_Fees