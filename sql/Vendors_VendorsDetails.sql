create table Vendor_Group(Group_Id int identity primary key,Group_Name  varchar(20)not null)

create table Vendors(Vendor_Id int identity primary key,Vendor_Name varchar(20) not null,
                    Group_Id int,constraint fk2 foreign key(Group_Id)
                    references Vendor_Group(Group_Id))

					insert into Vendor_Group values('Royal Banglores')
					insert into Vendor_Group values('Chennai SuperKings')
					insert into Vendor_Group values('Mumbai Indians')

					insert into Vendors values('Amit',1)
					insert into Vendors values('Amitabh',2)
					insert into Vendors values('Amisha',3)

select * from Vendor_Group
select * from Vendors