create table Products3(Product_Id int identity primary key,Product_Name varchar(20) not null,
                       Unit_Price dec(10,3) constraint positive_price CHECK(Unit_Price>0))

					   insert into Products3 values('Refrigerator',10000)
					   insert into Products3 values('Microwave Owen',5000)
					   insert into Products3 values('Bed',20000)

select * from Products3