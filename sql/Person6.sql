create table Persons6(Year int,Subject varchar(20),Category varchar(20),Country varchar(20),Winner varchar(20))

insert into Persons6 values(1970,'Physics','Scientist','India','Hannes Alfven')
insert into Persons6 values(1970,'Chemistry','Scientist','USA','Bernard Katz ')
insert into Persons6 values(1970,'Physics','Scientist','Swedan','Louis Neel')
insert into Persons6 values(1970,'Economics','Scientist','India','Paul Samuelson')
insert into Persons6 values(1970,'Biology','Scientist','India','Ulf von Euler')
insert into Persons6 values(1970,'Physiology','Scientist','Africa','Paul Samuelson ')

select Year,Subject,Category,Country,Winner from Persons6 where Year=1970 and Subject not in('Physiology','Economics')

select * from Persons6