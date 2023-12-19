create table person1(Person_Id int identity primary key,Fisrt_Name varchar(20) not null,
                    Last_Name varchar(20) not null,Email varchar(50), UNIQUE(Email))

					insert into person1 values('Anurag','Gajbhiye','anu24@gmail.com')
					insert into person1 values('Rushikesh','Patel','rushi234@gmail.com')
					insert into person1 values('Sayali','Kapse','sayalikap256@gmail.com')
					insert into person1 values('Rushi','Bhoyar','rushi234@gmail.com')
					insert into person1 values('Ruhi','Manekar','ruhi908@gmail.com')

select * from person1
