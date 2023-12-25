create table ProductQty(Product_Id int,
                        Region varchar(50),
						Product_Name varchar(50),
						Year int,
						Quantity int,
						Price int
						);

						insert into ProductQty values(1,'East','Computer',2012,'2',90000),
						                             (2,'North','Laptop',2013,'4',65000),
						                             (3,'West','Keyboard',2014,'6',1000),
						                             (4,'South','Desktop',2012,'3',80000),
						                             (5,'East','Mouse',2013,'4',600),
						                             (6,'North','Hark Disk',2014,'2',4400),
						                             (7,'East','Laptop',2012,'1',65000),
						                             (8,'East','Pen Drive',20124,'5',200)
select * from ProductQty

select Product_Name,Quantity,Price
from ProductQty
Where Quantity in(SELECT MIN(Quantity) As "Minimum Quantity"
FROM ProductQty);