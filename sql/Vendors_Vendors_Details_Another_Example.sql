create table Vendors_Group1(Group_Id int identity primary key,Group_Name varchar(20))

create table Vendors1(Vendors_Id int identity primary key,Vendors_Name varchar(20),
                      Group_Id int not null,constraint fk3 foreign key(Group_Id)
					  references Vendors_Group1(Group_Id))

					  insert into Vendors_Group1(Group_Name) values('Chennai Super Kings')
					  insert into Vendors_Group1(Group_Name) values('Mumbai Indians')
					  insert into Vendors_Group1(Group_Name) values('Royal Banglore')
					  insert into Vendors_Group1(Group_Name) values('Kolkalta NightRiders')

					  insert into Vendors1(Vendors_Name,Group_Id) values('Amisha',1)
					  insert into Vendors1(Vendors_Name,Group_Id) values('Ravi',2)
					  insert into Vendors1(Vendors_Name,Group_Id) values('Jayant',9)
					  insert into Vendors1(Vendors_Name,Group_Id) values('Nayan',4)

					  select * from Vendors_Group1
					  select * from Vendors1