create table Persons1(Year int,Subject varchar(20),Category varchar(20),Country varchar(20),Winner varchar(20))

insert into Persons1 values(1970,'Physics','Scientist','India','Hannes Alfven')
insert into Persons1 values(1971,'Chemistry','Scientist','USA','Louis Neel ')
insert into Persons1 values(1970,'Biology','Scientist','Swedan','Bernard Katz')
insert into Persons1 values(1971,'Mathematics','Scientist','India','Paul Samuelson')
insert into Persons1 values(1970,'Physiology','Scientist','India','Ulf von Euler')

select Year,Subject,Winner from Persons1 where Winner='Bernard Katz'

select * from Persons1