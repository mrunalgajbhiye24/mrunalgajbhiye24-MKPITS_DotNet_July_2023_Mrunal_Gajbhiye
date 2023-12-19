create table person2(Person_Id int identity primary key,Fisrt_Name varchar(20) not null,
                    Last_Name varchar(20) not null,Email varchar(50),constraint unique_name UNIQUE(Email))

					insert into person2 values('Anurag','Gajbhiye','anu24@gmail.com')
					insert into person2 values('Rushikesh','Patel','rushi234@gmail.com')
					insert into person2 values('Sayali','Kapse','sayalikap256@gmail.com')
					insert into person2 values('Rushi','Bhoyar','rushi234@gmail.com')
					insert into person2 values('Ruhi','Manekar','ruhi908@gmail.com')

select * from person2