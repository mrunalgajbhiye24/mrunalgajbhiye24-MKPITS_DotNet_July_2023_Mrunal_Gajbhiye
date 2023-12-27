create table Product15(Product_Id int,
                       Product_Name varchar(50),
					   List_Price int
					   );
					   insert into Product15 values(11,'Computer',500),
					                               (22,'Mouse',400),
												   (33,'Keyboard',300),
												   (44,'Desktop',600),
												   (55,'Laptop',100)
select * from Product15

DECLARE @product_name varchar(50),
        @list_Price decimal

DECLARE cursor_product4 CURSOR
FOR SELECT Product_Name,List_Price
FROM Product15
where Product_Name='Mouse'

OPEN cursor_product4;

FETCH NEXT FROM cursor_product4 INTO 
    @product_name, 
    @list_price;
WHILE @@FETCH_STATUS = 0
    BEGIN
PRINT @product_name +' '+CAST(@list_price AS varchar);
   FETCH NEXT FROM cursor_product4 INTO 
    @product_name, 
    @list_price;            
    END;
	
CLOSE cursor_product4
DEALLOCATE cursor_product4