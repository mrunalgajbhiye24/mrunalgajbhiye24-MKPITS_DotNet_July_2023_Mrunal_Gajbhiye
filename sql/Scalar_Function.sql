create table CalculateTax(Income1 int,
                          Tax_Rate decimal
						  );
						  insert into CalculateTax values(50000,18)
						  insert into CalculateTax values(250000,15)
select * from CalculateTax
drop table CalculateTax
create function fun2
(@incomes1 int,@tax_rate decimal)
returns int
as begin
return(Select @incomes1 / @tax_rate*100)
end+
drop function fun2
Select dbo.fun2(Income1,Tax_Rate) as detail from CalculateTax