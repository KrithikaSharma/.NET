-- ***********		SQL Assignment 20th Feb		****************

/*
1.	Write a T-SQL Program to generate complete payslip of a given employee with respect to the following condition
a)	HRA  as 10% Of sal
b)	DA as  20% of sal
c)	PF as 8% of sal
d)	IT as 5% of sal
e)	Deductions as sum of PF and IT
f)	Gross Salary as sum of SAL,HRA,DA and Deductions
g)	Net salary as  Gross salary- Deduction
*/

use ZensarDB

create table empAssignment(eid int primary key,ename varchar(20), desig varchar(30), salary int)

insert into empAssignment
values(501,'Adarsh','Analyst',40000),
(504,'Babitha','Manager',80000),
(509,'Siddhart','Developer',75000)

Select * from empAssignment

create or alter proc payslip(@empid int)
as
begin
declare @HRA float, @DA float, @PF float,@IT float, @deductions float,@GrossSal float, @netSalary float
declare @empname varchar(20)
set @HRA=0.1*(select salary from empAssignment where eid=@empid)
set @DA=0.2*(select salary from empAssignment where eid=@empid)
set @PF=0.08*(select salary from empAssignment where eid=@empid)
set @IT=0.05*(select salary from empAssignment where eid=@empid)
set @deductions=@PF+@IT
set @GrossSal= (select salary from empAssignment where eid=@empid)+@HRA+@DA+@deductions
set @netSalary=@GrossSal-@deductions
set @empname=(select ename from empAssignment where eid=@empid)
print 'Payslip of employee '+@empname+' is: '
print 'HRA = '+cast(@HRA as varchar)+', DA = '+cast(@DA as varchar) +', PF = '+cast(@PF as varchar)+', IT = '+cast(@IT as varchar)+', Deductions = '+cast(@deductions as varchar)+', gross salary = '+cast(@GrossSal as varchar)+', Net salary = '+cast(@netSalary as varchar)
end

exec payslip 504

-------------------------------------------------------------------------------------------------------------------------

/*
2.	Write a T-SQL Program to Display complete result of a given student.
(Note: Consider 10th standard result sheet and Student table structure as (sno,sname,maths,phy,comp)
*/
create table studentAssignment(sno int primary key, sname varchar(20),maths int, phy int, comp int)

insert into studentAssignment
values(1,'Ramya',84,67,89),
(2,'Samatha',53,34,65),
(3,'Asra',62,73,86)

select * from studentAssignment

create or alter function Display(@sRNo int) -- need to use proc instead of procedure
--returns int
returns varchar(20)
as
begin
declare @m int,@p int,@c int
--declare @@n varchar(20)
set @m=(select maths from studentAssignment where sno=@sRNo)
set @p=(select phy from studentAssignment where sno=@sRNo)
set @c=(select comp from studentAssignment where sno=@sRNo)
-- set @@n=(select sname from studentAssignment where sno=@sRNo) 
-- print 'result of '+@@n+' is: ' -- throwing error
return (select sname from studentAssignment where sno=@sRNo)+' '+cast((@m+@p+@c) as varchar)
end

declare @n varchar(20)
print(ZensarDB.dbo.Display(1))

-------------------------------------------------------------------------------------------------------------------------

/*3.	Write a T-SQL Program to find the factorial of a given number.*/

create or alter procedure factorial(@num int)
as
begin
	declare @facto int, @n int
	set @n=1
	set @facto=1
	while @n<=@num
	begin
		set @facto =@facto*@n
		set @n=@n+1
	end
	print 'Factorial of '+cast(@num as varchar) +' is: '
	print @facto
end

execute factorial 4

-------------------------------------------------------------------------------------------------------------------------
/*4. Create a stored procedure to generate multiplication tables up to a given number.*/

create or alter proc multiplication(@n int)
as
begin
declare @i int
set @i=1
while @i<=10
	begin
		print cast(@n as varchar)+' * '+cast(@i as varchar)+' = '+cast((@n*@i) as varchar)
		set @i=@i+1
	end
end

exec multiplication 6

-------------------------------------------------------------------------------------------------------------------------
/*
5.	Create a user defined function calculate Bonus for all employees of a  given job using following conditions
a.	       For Deptno10 employees 15% of sal as bonus.
b.	       For Deptno20 employees  20% of sal as bonus
c.	      For Others employees 5%of sal as bonus
*/

select * from EMP

-- inline - table valued functions
create or alter function calculateBonus(@j varchar(15))
returns table
as
return(select ename,job,sal,deptno from emp where job=@j)
go
update emp set sal=sal+(sal*0.15) where deptno=10
update emp set sal=sal+(sal*0.2) where deptno=20
update emp set sal=sal+(sal*0.05) where deptno<>10 and  deptno<>20


select * from calculateBonus('clerk')
select * from calculateBonus('president')

select * from emp

-------------------------------------------------------------------------------------------------------------------------
-- this question not done by me

/*
6.	Create a trigger to restrict data manipulation on EMP table during General holidays. Display the error message like “Due to Independence day you cannot manipulate data”
Note: Create holiday table as (holiday_date,Holiday_name) store at least 4 holiday details
*/

create table holiday(holiday_date date,holiday_name varchar(30))

insert into holiday
values('2022-08-15','Independence_day'),
('2022-12-25','Christmas'),
('2022-01-01','New Year'),
('2022-10-05','Dushera')

select * from holiday

create or alter trigger RestrictDataManipulation
on Holiday
instead of update
as
  Raiserror('Cannot make any changes since, it is fixed holiday',16,1)
----execution to check------
  update Holiday set holiday_date='29-March' where holiday_date='26-JAN'

  select * from holiday