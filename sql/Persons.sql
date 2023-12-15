create table Persons(Year int,Subject varchar(20),Category varchar(20),Country varchar(20),Winner varchar(20))

insert into Persons values(1970,'Physics','Scientist','India','Riya Chaudhary')
insert into Persons values(1971,'Chemistry','Scientist','USA','Prachi Dhaiwale')
insert into Persons values(1970,'Biology','Scientist','Swedan','Pooja Shende')
insert into Persons values(1971,'Mathematics','Scientist','India','Ayushi Shendre')
insert into Persons values(1970,'Physiology','Scientist','India','Neeta Gajbhiye')

select Year,Subject,Winner from Persons where Year=1971

select * from Persons