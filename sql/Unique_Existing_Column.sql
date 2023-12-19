create table persons3(Person_Id int identity primary key,
                      First_Name varchar(20) not null,
					  Last_Name varchar(20) not null,
					  Email varchar(50),
					  Phone bigint
					  );

					  insert into persons3 values('Ruhi','Manekar','ruhi234@gmail.com',9787867382)
					  insert into persons3 values('Sakshi','Ganvir','sakshi89234@gmail.com',9787557382)
					  insert into persons3 values('Mahi','Gedam','mahi890@gmail.com',9787867987)
					  insert into persons3 values('Navya','Patil','navya289@gmail.com',8887867382)
					  insert into persons3 values('Mayuri','Kale','mayurikale345@gmail.com',9997867382)
					  insert into persons3 values('Sonali','Raykavar','sonali@gmail.com',9887867382)

ALTER table persons3
add constraint unique_name1 UNIQUE(First_Name)

delete  from persons3 where Person_Id = 6

insert into persons3 values('Sakshi','Ganvir','sakshi89234@gmail.com',9787557382);

select * from persons3
drop table persons3