create table person_skills(id int primary key,
                           Person_Id int,
						   Skill_Id int,
						   update_at Datetime,
						   UNIQUE(Person_Id,Skill_Id));

						   insert into person_skills values(1,111,09,'2021-12-12 ')
						   insert into person_skills values(2,114,08,'2021-12-12')
						   insert into person_skills values(3,112,10,'2021-12-12')
                           insert into person_skills values(4,113,11,'2021-12-12')

select * from person_skills
drop table person_skills