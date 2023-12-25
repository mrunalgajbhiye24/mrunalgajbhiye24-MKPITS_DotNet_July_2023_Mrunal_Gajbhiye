create table Products12(Product_Id int,
                        Product_Name varchar(100),
						Price int,
						Quantity int
						);

						insert into Products12 values(11,'Computer',90000,2),
						                             (22,'Hard Disk',50000,4),
						                             (33,'Pen drive',1000,2),
						                             (44,'Laptop',65000,1),
						                             (55,'Keyboard',2000,4)
select * from Products12
Select count(Price) AS 'Total' from Products12

Select count(Price) AS 'Total' from Products12 
Where Product_Name ='Keyboard'

Select Product_Name,count(price) AS 'Total' From Products12
Group By Product_Name

