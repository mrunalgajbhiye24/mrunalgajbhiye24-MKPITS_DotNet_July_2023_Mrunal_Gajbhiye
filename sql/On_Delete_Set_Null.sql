create table Vendors_Group4(Group_Id int identity primary key,Group_Name varchar(100))

create table Vendors4(Vendor_Id int identity primary key,Vendor_Name varchar(20) not null,
                     Group_Id int,
					 constraint fk9 foreign key (Group_Id) 
					 references Vendors_Group4(Group_Id) on delete set null)

					 insert into Vendors_Group4 values('Fendal')
					 insert into Vendors_Group4 values('Infosys')
					 insert into Vendors_Group4 values('Wipro')

					 insert into Vendors4 values('Sakshi',1)
					 insert into Vendors4 values('Rohit',2)
					 insert into Vendors4 values('Rahul',3)

					 delete from Vendors_Group4 where Group_Id=2


drop table Vendors_Group4
drop table Vendors4