create table Products6(Product_Id int identity primary key,Product_Name varchar(20) not null,
                       Unit_Price dec(10,2) , Discounted_Price dec(10,2),CHECK(Unit_Price>0), CHECK(Discounted_Price>0),
					   constraint valid_price CHECK(Discounted_Price>0 and Discounted_Price<Unit_Price))

					   insert into Products6 values('Samsung',35000,15)
					   insert into Products6 values('Vivo Y17',20000,14)
					   insert into Products6 values('One Plus',35000,20)
					   insert into Products6 values('Galaxy Pixel',25000,10)

select * from Products6