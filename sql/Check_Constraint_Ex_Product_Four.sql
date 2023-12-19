create table Products4(Product_Id int identity primary key,Product_Name varchar(20) not null,
                       Unit_Price dec(10,2) CHECK(Unit_Price>0), Discounted_Price dec(10,2) CHECK(Discounted_Price>0),
					   CHECK(Discounted_Price<Unit_Price))

					   insert into Products4 values('TV',35000,15)
					   insert into Products4 values('Refrigerator',20000,14)
					   insert into Products4 values('MicroWave Owen',35000,20)
					   insert into Products4 values('Washing Machine',25000,10)

select * from Products4
