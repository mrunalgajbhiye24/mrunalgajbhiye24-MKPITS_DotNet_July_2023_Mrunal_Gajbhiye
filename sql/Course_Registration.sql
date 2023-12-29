create table TableNation(Nation_Id int primary key,
                    Nation_Name varchar(50)
					);
					insert into TableNation values(1,'India'),
					                         (2,'Africa'),
											 (3,'USA')
select * from TableNation
-----------------------State--------------------------------------
create table TableStates(State_Id int primary key,
                    Nation_Id int,
				    State_Name varchar(500),
				    constraint fk31 foreign key(Nation_Id) references TableNation(Nation_Id)
					);
					insert into TableStates values(11,1,'Maharashtra'),
						                     (22,2,'Botswana'),
											 (33,3,'California')
select * from TableStates
--------------------------City-------------------------------------
create table TableCity(City_Id int primary key,
                       State_Id int,
				       City_Name varchar(500),
				       constraint fk32 foreign key(State_Id) references TableStates(State_Id)
				       );
					   insert into TableCity values(111,11,'Mumbai'),
				                                    (222,22,'Gaboroni'),  
									                (333,33,'Los Angeles')
select * from TableCity
------------------------Course-------------------------------------
create table TableCourseRegDetails(CourseReg_Id int primary key,
                              Category_Id int,
							  Full_Name varchar(500),
							  Gender_id int
							  );
							  insert into TableCourseRegDetails values(121,01,'Sayali kapse',21),
							                                     (122,02,'Puvri Bhoyar',22), 
																 (123,03,'Ruhi Manekar',23)
select * from TableCourseRegDetails
-------------------------------RegAddress--------------------------
create table TablesRegAddress(RegAddress_Id int primary key,
                             CourseReg_id int,
							 Nation_Id int,
							 State_Id int,
							 City_Id int
							 constraint fk37 foreign key(CourseReg_id) references TableCourseRegDetails(CourseReg_id),
							 constraint fk38 foreign key(Nation_Id) references TableNation(Nation_Id),
							 constraint fk39 foreign key(State_Id) references TableStates(State_Id),
							 constraint fk40 foreign key(City_Id) references TableCity(City_Id)
							 );
							 insert into TablesRegAddress values(31,121,1,11,111),
							                                   (32,122,2,22,222),
															   (33,123,3,33,333)
select * from TablesRegAddress
---------------------------Fess_Details---------------------------
create table TablesFeeDetails(Fee_Id int primary key,
                             CourseReg_Id int,
							 Total_Amount decimal,
							 MinPer decimal,
							 Paid_Amount decimal,
							 BalAmount decimal,
							 Paid_Date datetime
							 constraint fk41 foreign key(CourseReg_Id) references TableCourseRegDetails(CourseReg_id)
							 );
							 insert into TablesFeeDetails values(10,121,90000,10000,10000,80000,'2023-10-01'),
							                                   (20,122,70000,20000,20000,50000,'2023-10-02'),
															   (30,123,60000,5000,5000,55000,'2023-10-02')
select * from TableNation
select * from TableStates
select * from TableCity
select * from TableCourseRegDetails
select * from TablesRegAddress
select * from TablesFeeDetails

