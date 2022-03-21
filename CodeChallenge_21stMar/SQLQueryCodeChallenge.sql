create database EmployeeManagement

use EmployeeManagement

create table Code_Employee(empno int primary key, empname varchar(50),empsal numeric(10,2) check(empsal>=25000), emptype varchar(1) check(emptype in ('C','P')))

sp_help Code_Employee


create or alter proc add_employee @empname varchar(50),@empsal numeric(10,2), @emptype varchar(1)
as
begin
declare  @i int
select @i=max(101) from Code_Employee
set @i=@i+1
Insert into Code_Employee values(@i,@empname,@empsal,@emptype)
end

Select * from Code_Employee
exec add_employee @empname='k', @empsal=29000,@emptype='C'