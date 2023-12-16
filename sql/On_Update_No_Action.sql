create table Vendors5(Group_Id int identity primary key,Group_Name varchar(20))

create table Vendors_Group6(Vendors_Id int identity primary key,Vendors_Name varchar(20),
                            Group_Id int,constraint fk10 foreign key(Group_Id) references Vendors5(Group_Id) 
							on update no action)
							
							insert into Vendors5 values('TCS')
							insert into Vendors5 values('Wipro')
							insert into Vendors5 values('Fendal')
							insert into Vendors5 values('Capgemini')
							insert into Vendors5 values('TechnoMile')

							insert into Vendors_Group6 values('Amit',1)
							insert into Vendors_Group6 values('Rohit',2)
                            insert into Vendors_Group6 values('Kunal',3)
                            insert into Vendors_Group6 values('Amar',4)
                            insert into Vendors_Group6 values('Anurag',5)

							insert into Vendors5 values('Accenture')
							insert into Vendors_Group6 values('Anuvedh',5)


select * from Vendors5
select * from Vendors_Group6