create table Salesman5(Salesman_Id  int,
                        Salesman_Name varchar(50),
						City varchar(50),
						Commission decimal,						
						);

						insert into Salesman5 values(1,'Monu','Nagpur',15),
						                             (2,'Sonali','Bhandara',20),
													 (3,'Chetan','Nagpur',10),
													 (4,'Jayant','Chandrapur',25),
													 (5,'Sayali','Nagpur',30),
													 (6,'Prachi','Bhandara',20),
													 (7,'Reetu','Chanrapur',15),
													 (8,'Sakshi','Bhandara',25)
select * from Salesman5

create table Customer17(Salesman_Id int,
                        Customer_Name varchar(50),
						City varchar(50),
						Grade int,
						Commission decimal
						);

						insert into Customer17 values(1,'Ruhi','Akola',100,15),
						                             (2,'Purvi','raipur',200,20),
													 (3,'Reena','ramtek',300,10),
													 (4,'Savi','Manser',400,25),
													 (5,'Vanshu','ramdham',500,30),
													 (6,'Mayuri','nagardhan',100,20),
													 (7,'Vrushali','kaneri',200,15),
													 (8,'Kiran','gondi',300,25)

select * from Customer17

SELECT Grade, COUNT (*)
FROM Customer17
GROUP BY Grade
HAVING Grade >
(SELECT AVG(Grade)
FROM Customer17
WHERE city = 'Akola');

