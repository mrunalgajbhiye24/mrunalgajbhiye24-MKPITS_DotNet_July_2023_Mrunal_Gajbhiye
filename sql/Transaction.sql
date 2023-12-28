CREATE TABLE Product16 (Product_id INT PRIMARY KEY,   
                      Product_name VARCHAR(40),   
                      Price INT,  
                      Quantity INT  
                      ); 
					  INSERT INTO Product16 VALUES(111, 'Mobile', 10000, 10),  
                                                (112, 'Laptop', 20000, 15),  
                                                (113, 'Mouse', 300, 20),  
                                                (114, 'Hard Disk', 4000, 25),  
                                                (115, 'Speaker', 3000, 20) 
select * from Product16
BEGIN TRANSACTION    
INSERT INTO Product16 VALUES(116, 'Headphone', 2000, 30)  
UPDATE Product16 SET Price = 450 WHERE Product_id = 113  
commit TRANSACTION

BEGIN TRANSACTION    
UPDATE Product16 SET Price = 5000 WHERE Product_id = 114  
DELETE FROM Product16 WHERE Product_id = 116 
select * from Product16  
ROLLBACK TRANSACTION  



