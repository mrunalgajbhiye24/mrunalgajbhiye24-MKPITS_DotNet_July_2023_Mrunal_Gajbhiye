create table Nobel_Prize(Year int,Subject varchar(20),Category varchar(20),Country varchar(20),Winner varchar(20))

insert into Nobel_Prize values(1971,'Physics','Scientist','India','Hannes Alfven')
insert into Nobel_Prize values(1972,'Chemistry','Scientist','USA','Bernard Katz ')
insert into Nobel_Prize values(1977,'Peace','Scientist','Swedan','Louis Neel')
insert into Nobel_Prize values(1974,'Economics','Scientist','India','Paul Samuelson')
insert into Nobel_Prize values(1975,'Biology','Scientist','India','Ulf von Euler')
insert into Nobel_Prize values(1965,'Physiology','Scientist','Africa','Paul Samuelson ')

select Year,Subject,Category,Country,Winner from Nobel_Prize where (Subject ='Physiology' and Year<1971 ) or (Subject ='Peace' and Year>=1974 )


select * from Nobel_Prize