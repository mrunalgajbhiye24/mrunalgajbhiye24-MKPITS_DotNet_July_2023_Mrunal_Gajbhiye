create table Products2(Product_Id int identity primary key,
                       Product_Name varchar(20) not null,
					   Unit_Price dec(10,2) CHECK (Unit_Price>0))

					   insert into Products2 values('Mouse',120)
					   insert into Products2 values('Keyboard',150)
					   
select * from Products2
