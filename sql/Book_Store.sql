create table Stores(Store_Id int primary key,Store_Name varchar(50),
                    Phone bigint,Email varchar(50),
                    Street varchar(50),City varchar(50),
					States varchar(50),Zip_Code int)

					insert into Stores values(1,'Ganesh Kirana Store',9876543218,'ganeshstore123@gmail.com','HB Town','Nagpur','Maharashtra',440035)
					insert into Stores values(2,'Guru Gobind Singh Clothes',9879583218,'guru345@gmail.com','Mahal','Nagpur','Maharashtra',440005)
					insert into Stores values(3,'MahaLaxmi Dhanya Bhandar',9996543218,'mahalaxmi908@gmail.com','Nandanvan','Nagpur','Maharashtra',400035)
					insert into Stores values(4,'Jay Mata Di General Store',9876555518,'jaymatadi3@gmail.com','Darshan Colony','Nagpur','Maharashtra',440035)
					insert into Stores values(5,'Antique Clothe Store',9888543218,'antique234@gmail.com','Itwari','Nagpur','Maharashtra',440025)

select * from Stores
drop table Stores

create table Staffs(Staff_Id int identity primary key,First_Name varchar(50),
                    Last_Name varchar(50),Email varchar(50),
					Phone bigint,Active int,Store_Id int,
					Manager_Id int,
					constraint fk12 foreign key(Store_Id) references Stores(Store_Id))

					insert into Staffs values('Moni','Patil','moni90@gmail.com',8898545842,90,1,123)
					insert into Staffs values('Vaibhav','Abhayankar','abhi789@gmail.com',8898920842,100,2,223)
					insert into Staffs values('Manish','Shende','123manish@gmail.com',7778545842,88,3,343)
					insert into Staffs values('Ayushi','Kale','ayushi234@gmail.com',7728545842,95,4,423)
					insert into Staffs values('Sakshi','Ganvir','sakshi456@gmail.com',8898545845,99,5,456)

select * from Staffs

create table Category(Category_id int identity primary key,
                      Category_Name varchar(100) not null)

					  insert into Category values('Car')
					  insert into Category values('Bus')
					  insert into Category values('Truck')
					  insert into Category values('Mini_Truck')

select * from Category

create table Brand(Brand_Id int identity primary key,
                   Brand_Name varchar(100))

				   insert into Brand values('Maruti Suzuki')
				   insert into Brand values('Audi')
				   insert into Brand values('Creta')
				   insert into Brand values('Verna')

select * from Brand

create table Products10(Product_Id int identity primary key,
                        Product_Name varchar(20) not null,
						Brand_Id int not null,
						Category_Id int not null,
						Model_Year smallint not null,
						List_Price dec(10,2) not null,
						constraint fk13 foreign key(Category_Id) references Category(Category_Id) ON DELETE CASCADE ON UPDATE CASCADE,
						constraint fk14 foreign key(Brand_Id) references Brand(Brand_Id) ON DELETE CASCADE ON UPDATE CASCADE);

						insert into Products10 values('Verna',1,1,2023,100000)
						insert into Products10 values('Creta',2,2,1995,350000)
						insert into Products10 values('Audi',3,3,1984,120000)
						insert into Products10 values('Maruti Suzuki',4,4,1990,160000)

select * from Products10
drop table Products10

create table Customer4(Customer_Id int identity primary key,
                       Fisrt_Name varchar(50) not null,
					   Last_Name varchar(50) not null,
					   Phone varchar(10) not null,
					   Email varchar(100) not null,
					   Street varchar(50),
					   City varchar(50),
					   States varchar(50),
					   Zip_Code int)

					   insert into Customer4 values('Ayushree','Shende','9875224562','ayushshree789@gmail.com','Nandanvan','Nagpur','Maharashtra',440032)
				       insert into Customer4 values('Moni','Gajbhiye','9875333562','moni856@gmail.com','HB Town','Bhandara','Maharashtra',440035)
					   insert into Customer4 values('Sayali','Kapse','8875224562','sayali678@gmail.com','Sakkardhara','Chandrapur','Maharashtra',440002)
					   insert into Customer4 values('Prachi','Dhaiwale','7895224562','567prachi@gmail.com','BhandePlot','Nagpur','Maharashtra',440001)

select * from Customer4

create table Orders5(Order_Id int identity primary key,
                     Customer_Id int,
					 Order_Status varchar(50),
					 Order_Date date,
					 Shipped_Date date,
					 Required_Date date, 
					 Store_Id int,
					 Staff_Id int
					 constraint fk15 foreign key(Customer_Id) references Customer4(Customer_Id),
					 constraint fk16 foreign key(Store_Id) references Stores(Store_Id),
					 constraint fk17 foreign key(Staff_Id) references Staffs(Staff_Id));

					 insert into Orders5 values(1,'Cancel','2023-10-09','2023-10-25','2023-10-20',1,1)
					 insert into Orders5 values(2,'Purchased','2023-09-12','2023-10-02','2023-09-25',2,2)
					 insert into Orders5 values(3,'Purchased','2023-01-01','2023-01-25','2023-01-20',3,3)
					 insert into Orders5 values(4,'Cancel','2023-11-01','2023-11-30','2023-11-20',4,4)

select * from Orders5

create table Order_Item(Order_Id int,
                        Item_id int,
						Product_Id int not null,
						Quantity int not null,
						List_Price dec(10,2) not null,
						Discount_Price dec(4,2) not null,
						Primary key(Order_Id,Item_id),
						constraint fk18 Foreign key(Order_Id) references Orders5(Order_Id),
						constraint fk19 Foreign key(Product_Id) references Products10(Product_Id));

						insert into Order_Item values(1,11,1,2,350000,15)
						insert into Order_Item values(2,12,2,1,30000,20)
						insert into Order_Item values(3,13,3,3,10000,25)
						insert into Order_Item values(4,14,4,4,40000,30)

select * from Order_Item
drop table Order_Item

create table Stock(Store_Id int,
                   Product_Id int,
				   Quantity int,
				   Primary Key(Store_Id,Product_Id),
				   constraint fk20 Foreign key(Store_Id) references Stores(Store_Id),
				   constraint fk21 Foreign key(Product_Id) references Products10(Product_Id));

				   insert into Stock values(1,1,4)
				   insert into Stock values(2,2,1)
				   insert into Stock values(3,3,9)
				   insert into Stock values(4,4,2)

select * from Stores
select * from Staffs
select * from Category
select * from Brand
select * from Products10
select * from Customer4
select * from Orders5
select * from Order_Item
select * from Stock