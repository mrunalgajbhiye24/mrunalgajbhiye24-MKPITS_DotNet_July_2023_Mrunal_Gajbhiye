create table Customer20(Customer_Id int,
                        Customer_Name varchar(20),
						Email varchar(50),
						Phone_Number bigint
						);
						insert into Customer20 values(1,'Sayali','sayali@gmail.com',9876543211),
						                             (2,'Purvi','purvi@gmail.com',8876543431),
													 (3,'Ruhi','ruhi@gmail.com',7873543214),
													 (4,'Aditi','aditi@gmail.com',9874443212),
													 (5,'Vidhi','vidhi@gmail.com',7776543231)
select * from Customer20

DECLARE @custid int,@Cust_Name varchar(50),@email varchar(50),@phone_no bigint

DECLARE cursor_cust4 CURSOR
For SELECT Customer_Id,Customer_Name,Email,Phone_Number
FROM Customer20
where Customer_Id>3;

OPEN cursor_cust4;

FETCH NEXT FROM cursor_cust4 INTO 
   @custid,
   @Cust_Name,
   @email,
   @phone_no

   WHILE @@FETCH_STATUS=0
   begin
   PRINT @Cust_Name + ' ' + CAST(@custid as varchar) + ' ' +@email+ ' ' +CAST(@phone_no as varchar);
   FETCH NEXT FROM cursor_cust4 INTO 
   @custid,
   @Cust_Name,
   @email,
   @phone_no
   END;

   CLOSE cursor_cust4
   DEALLOCATE cursor_cust4