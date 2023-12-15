create table Vendors_Group2(Group_Id int identity primary key,Group_Name  varchar(20)not null)

create table Vendors2(Vendor_Id int identity primary key,Vendor_Name varchar(20) not null,
                    Group_Id int,constraint fk5 foreign key(Group_Id)
                    references Vendors_Group2(Group_Id))

					insert into Vendors_Group2 values('Royal Banglores')
					insert into Vendors_Group2 values('Chennai SuperKings')
					insert into Vendors_Group2 values('Mumbai Indians')

					insert into Vendors2 values('Sakshi',4)
					insert into Vendors2 values('Shubhum',3)
					insert into Vendors2 values('Amisha',3)
					insert into Vendors2 values('Rohit',4)

                    select * from Vendors_Group2
					delete from Vendors2 where Group_Id=3
					insert into Vendors2 values('Shrutika',3)
					select * from Vendors2


					drop table Vendors_Group2
					drop table Vendors2




					 
