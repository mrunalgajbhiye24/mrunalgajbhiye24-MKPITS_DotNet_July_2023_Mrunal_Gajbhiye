create table Vendors_Group3(Group_Id int identity primary key,Group_Name varchar(100))

create table Vendors3(Vendor_Id int identity primary key,Vendor_Name varchar(20) not null,
                     Group_Id int not null,constraint fk8 foreign key (Group_Id) 
					 references Vendors_Group3(Group_Id) on delete cascade)

					 insert into Vendors_Group3 values('Fendal')
					 insert into Vendors_Group3 values('Infosys')
					 insert into Vendors_Group3 values('Wipro')

					 insert into Vendors3 values('Sakshi',1)
					 insert into Vendors3 values('Rohit',2)
					 insert into Vendors3 values('Rahul',3)

					 delete from Vendors_Group3 where Group_Id=2
select * from Vendors_Group3
select * from Vendors3