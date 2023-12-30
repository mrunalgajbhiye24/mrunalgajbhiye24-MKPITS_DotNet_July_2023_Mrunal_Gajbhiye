create table Teacher_Details(Teacher_Id int primary key,
                             Teacher_Age int
							 );
							 insert into Teacher_Details values(1,30)
							 insert into Teacher_Details values(2,24)
							 insert into Teacher_Details values(3,26)
							 insert into Teacher_Details values(4,34)
							 insert into Teacher_Details values(5,32)
							 insert into Teacher_Details values(6,25)
							 insert into Teacher_Details values(7,29)
select * from Teacher_Details
----------------------------------------------------------------------------------------------------------------------------------
create table Teacher_Subjects(Teacher_Id int,
                              Subject varchar(50)
							  constraint fk44 foreign key(Teacher_Id) references Teacher_Details(Teacher_Id)
							  );
							  insert into Teacher_Subjects values(1,'Maths')
							  insert into Teacher_Subjects values(2,'Chemistry')
							  insert into Teacher_Subjects values(3,'Biology')
							  insert into Teacher_Subjects values(4,'Zoology')
							  insert into Teacher_Subjects values(5,'Physics')
							  insert into Teacher_Subjects values(6,'Hindi')
							  insert into Teacher_Subjects values(7,'English')
select * from Teacher_Subjects 



