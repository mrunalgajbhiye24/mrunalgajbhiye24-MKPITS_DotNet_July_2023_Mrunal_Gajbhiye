create table Persons4(Year int,Subject varchar(20),Category varchar(20),Country varchar(20),Winner varchar(20))

insert into Persons4 values(1970,'Physics','Scientist','India','Hannes Alfven')
insert into Persons4 values(1972,'Chemistry','Scientist','USA','Bernard Katz ')
insert into Persons4 values(1974,'Physics','Scientist','Swedan','Louis Neel')
insert into Persons4 values(1971,'Mathematics','Scientist','India','Paul Samuelson')
insert into Persons4 values(1975,'Biology','Scientist','India','Ulf von Euler')

select Year,Subject,Category,Country,Winner from Persons4  where Winner='Louis Neel'

select * from Persons4