create table Person(Year int,Subject varchar(20),Category varchar(20),Country varchar(20),Winner varchar(20))

insert into Person values(1970,'Physics','Scientist','India','Riya Chaudhary')
insert into Person values(1971,'Chemistry','Scientist','USA','Prachi Dhaiwale')
insert into Person values(1970,'Biology','Scientist','Swedan','Pooja Shende')
insert into Person values(1972,'Mathematics','Scientist','India','Ayushi Shendre')
insert into Person values(1970,'Physiology','Scientist','India','Neeta Gajbhiye')

select Year,Subject,Winner from Person where Year=1970

select * from Person