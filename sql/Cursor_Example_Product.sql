create table Product13(Product_Id int,
                       Product_Name varchar(50),
					   List_Price int
					   );
					   insert into Product13 values(11,'Computer',65000),
					                               (22,'Mouse',70000),
												   (33,'Keyboard',60000),
												   (44,'Desktop',50000),
												   (55,'Laptop',75000)
select * from Product13

DECLARE @product_name varchar(50),
        @list_Price decimal

DECLARE cursor_product1 CURSOR
FOR SELECT Product_Name,List_Price
FROM Product13

OPEN cursor_product1;

FETCH NEXT FROM cursor_product1 INTO 
    @product_name, 
    @list_price;
PRINT @product_name + CAST(@list_price AS varchar);
WHILE @@FETCH_STATUS = 0
    BEGIN
       
        FETCH NEXT FROM cursor_product1 INTO 
            @product_name, 
            @list_price;
            
          PRINT @product_name + CAST(@list_price AS varchar);
    END;
	
CLOSE cursor_product1
DEALLOCATE cursor_product1