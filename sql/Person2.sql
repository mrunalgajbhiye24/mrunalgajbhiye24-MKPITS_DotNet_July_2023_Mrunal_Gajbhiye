create table Persons2(Year int,Subject varchar(20),Category varchar(20),Country varchar(20),Winner varchar(20))

insert into Persons2 values(1950,'Physics','Scientist','India','Hannes Alfven')
insert into Persons2 values(1971,'Chemistry','Scientist','USA','Louis Neel ')
insert into Persons2 values(1970,'Biology','Scientist','Swedan','Bernard Katz')
insert into Persons2 values(1971,'Mathematics','Scientist','India','Paul Samuelson')
insert into Persons2 values(1970,'Physics','Scientist','India','Ulf von Euler')

select Year,Subject,Winner from Persons2 where Year=1950 and Subject='Physics'

select * from Persons2