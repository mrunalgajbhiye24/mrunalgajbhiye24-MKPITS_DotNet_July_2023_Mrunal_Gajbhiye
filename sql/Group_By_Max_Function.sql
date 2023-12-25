create table ProductQty5(Product_Id int,
                        Region varchar(50),
						Product_Name varchar(50),
						Year int,
						Quantity int,
						Price int
						);

						insert into ProductQty5 values(1,'East','Computer',2012,'2',90000),
						                             (2,'North','Laptop',2013,'4',65000),
						                             (3,'West','Keyboard',2014,'6',1000),
						                             (4,'South','Desktop',2012,'6',80000),
						                             (5,'East','Mouse',2013,'4',600),
						                             (6,'North','Hark Disk',2014,'2',4400),
						                             (7,'East','Laptop',2012,'1',65000),
						                             (8,'East','Pen Drive',20124,'6',200)
select * from ProductQty5

select Product_Name,MAX(Price) As "Maximum Price"
from ProductQty5
GROUP BY Product_Name
Having MAX(Price)>1000;