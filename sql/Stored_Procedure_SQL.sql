select * from Products10

SELECT Product_Name,List_Price 
FROM Products10
ORDER BY Product_Name
-------------------------------------------------
create Proc prod1
as 
begin
select * from Products10
end;

exec prod1
--------------------------------------------------
create Proc mproc2
as 
begin
select * from Products10 where Model_Year=1984
end;

exec mproc2

exec sp_help
---------------------------------------------------
alter Proc prod1
as
begin 
select Product_Name,List_Price from Products10 
order by List_Price
end

exec prod1
----------------------------------------------------
alter Proc mproc2
as
begin
insert into Products10 values('Mercedes',4,4,1997,350000)
select * from Products10
end

------------------------------------------------------
create proc prod2(@minprice as decimal)
as 
begin
select * from Products10 
where List_Price>@minprice
order by List_Price
end;

exec prod2 330000
-------------------------------------------------------
create proc prod3(@pn as varchar(20))
as
begin 
select * from Products10 
where Product_Name=@pn
end

exec prod3 'SUVs'
--------------------------------------------------------
create proc prod4(@pname as varchar(20),@p as decimal)
as
begin
select * from Products10
where Product_Name = @pname
and List_Price >= @p
ORDER by Product_Name
end;

exec prod4 'Petrol',160000
---------------------------------------------------------
create procedure prod8(@minp as decimal,@maxp as decimal)
as
begin
select * from Products10
where List_Price>@minp and List_Price<@maxp
end

exec prod8 100000,350000
---------------------------------------------------------


