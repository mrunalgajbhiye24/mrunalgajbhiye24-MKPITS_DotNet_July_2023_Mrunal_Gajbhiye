create table TableProductGSTDetails(Product_Gst_Id int primary key,
                                    Gst_Detail_Name varchar(500),
									CGST decimal,
									SGST decimal,
									IGST decimal
									);
									insert into TableProductGSTDetails values(1,'Refrigerator',15,10,20),
									                                         (2,'Computer',10,30,15),
																			 (3,'Laptop',20,15,10)
select * from TableProductGSTDetails
---------------------------------------------------------------------------------------------------------------------------------
create table TableProductCategory(Product_Category_Id int primary key,
                                  Product_Type_Name varchar(500),
								  Product_Gst_Id int,
								  constraint fk42 foreign key(Product_Gst_Id) references TableProductGSTDetails(Product_Gst_Id)
								  );
								  insert into TableProductCategory values(11,'Classic Refrigerator',1),
								                                         (22,'Mini Computer',2),
																		 (33,'MacBook',3)
select * from TableProductCategory
----------------------------------------------------------------------------------------------------------------------------------
create table TableProduct(Product_Id int primary key,
                          Product_Type_Id int,
						  Product_Name varchar(500)
						  );
						  insert into TableProduct values(111,101,'Mouse'),
						                                 (222,102,'Keyboard'),
														 (333,103,'Pen Drive')
select * from TableProduct
-----------------------------------------------------------------------------------------------------------------------------------
create table TableInvoiceDetails(Invoice_Detail_Id int,
                                 Customer_Name varchar(500),
								 Customer_Contact varchar(15),
								 Product_Category_Id int,
								 Product_Id int,
								 Residential_Type_id int,
								 Invoice_Date datetime,
								 Quantity decimal,
								 price decimal,
								 CGST decimal,
								 SGST decimal,
								 IGST decimal,
								 CGST_Value decimal,
								 SGST_Value decimal,
								 IGST_Value decimal,
								 Total_Amount decimal
								 constraint fk43 foreign key(Product_Category_Id) references TableProductCategory(Product_Category_Id),
								 constraint fk44 foreign key(Product_Id) references TableProduct(Product_Id)
								 );
                           
								 insert into TableInvoiceDetails values(21,'Purvi Bhoyar','9876543211',11,111,31,'2023-10-03',2,20000,15,10,20,100,100,100,30000),
								                                       (22,'Ruhi Manekar','8886543213',22,222,32,'2023-10-03',1,65000,10,30,15,100,100,100,90000),
																	   (33,'Aditi Zade','7756544213',33,333,33,'2023-10-04',2,50000,20,15,10,100,100,100,80000)
select * from TableProductGSTDetails
select * from TableProductCategory
select * from TableProduct
select * from TableInvoiceDetails

								 

