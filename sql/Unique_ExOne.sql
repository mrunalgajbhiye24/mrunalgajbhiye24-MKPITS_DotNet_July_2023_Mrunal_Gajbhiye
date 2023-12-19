create table person(Person_Id int identity primary key,Fisrt_Name varchar(20) not null,
                    Last_Name varchar(20) not null,Email varchar(50) UNIQUE)

					insert into person values('Anurag','Gajbhiye','anu24@gmail.com')
					insert into person values('Rushikesh','Patel','rushi234@gmail.com')
					insert into person values('Sayali','Kapse','sayalikap256@gmail.com')
					insert into person values('Rushi','Bhoyar','rushi234@gmail.com')
					insert into person values('Ruhi','Manekar','ruhi908@gmail.com')

select * from person
drop table person