create database ZensarDB
use ZensarDB

-- creating tables in ZensarDB 
create table EMP(empno int primary key, ename varchar(20) not null, job varchar(20) not null, mgr int, hiredate varchar(15) not null, sal int not null, comm int, deptno int not null) 
create table DEPT(deptno int, dname varchar(15), loc varchar(20)) 
 
-- inserting values  
insert into EMP 
values(7369,'smith','clerk',7902,'17-dec-80',800,null,20), 
(7499,'allen','salesman',7698,'20-feb-81',1600,300,30), 
(7521,'ward','salesman',7698,'22-feb-81',1250,500,30), 
(7566,'jones','manager',7839,'02-apr-81',2975,null,20), 
(7654,'martin','salesman',7698,'28-sep-81',1250,1400,30), 
(7698,'BLAKE','MANAGER',7839,'01-MAY-81',2850,null,30), 
(7782,'CLARK','MANAGER',7839,'09-JUN-81',2450,null,10), 
(7788,'SCOTT','ANALYST',7566,'19-APR-87',3000,null,20), 
(7839,'KING','PRESIDENT',null,'17-NOV-81',5000,null,10), 
(7844,'TURNER','SALESMAN',7698,'08-SEP-81',1500,0,30), 
(7876,'ADAMS','CLERK',7788,'23-MAY-87',1100,null,20), 
(7900,'JAMES','CLERK',7698,'03-DEC-81',950,null,30), 
(7902,'FORD','ANALYST',7566,'03-DEC-81',3000,null,20), 
(7934,'MILLER','CLERK',7782,'23-JAN-82',1300,null,10) 
 
insert into DEPT 
values(10,'ACCOUNTING','NEW YORK') , 
(20,'RESEARCH','DALLAS'), 
(30,'SALES','CHICAGO'), 
(40,'OPERATIONS','BOSTON ') 
 
-- showing values 
select * from EMP 
select * from DEPT 
 
 
-- tasks 
-- 1.Retrieve a list of MANAGERS. 
select distinct(mgr) from emp

-- 2. Find out salary of both MILLER and SMITH.
select ename,sal from emp where ename='miller' or ename='smith'

-- 3. Find out the names and salaries of all employees earning more than 1000 per month. 
select ename,sal from EMP where sal>1000

-- 4. Display the names and salaries of all employees except JAMES. 
select ename,sal from EMP where ename!='james'

-- 5. Find out the details of employees whose names begin with ‘S’. 
select * from EMP where ename like 's%'

-- 6. Find out the names of all employees that have ‘A’ anywhere in their name.
select * from EMP where ename like '%a%'

-- 7. Find out the names of all employees that have ‘L’ as their third character in their name. 
select ename from EMP where ename like '__l%'

-- 8. Find out the names of the employees whose name begin with ‘A’ or ‘M’. 
select ename from EMP where ename like'a%' or ename like 'm%'

-- 9. Compute yearly salary of SMITH. 
select ename,sal*12 as Yearly_Salary from EMP where ename='smith'

-- 10. Compute daily salary of JONES. (assuming given is monthly salary)
select ename,sal/28 from emp as Daily_Salary where ename='jones'

-- 11. Calculate the total monthly salary of all employees.
--given salary is monthly or daily....????if daily then
select  ename,sal*28 as monthly_salary from emp

-- 12. Print the average annual salary. 
select avg(sal*365) as avg_annual_salary from emp

-- 13. Select the name, job, salary, department number of all employees except SALESMAN from department number 30. 
select ename,job,sal,deptno from EMP where job not like 'salesman' and deptno=30

-- 14. List unique departments of the EMP table. 
select distinct(d.dname) from DEPT d,EMP e where d.deptno=e.deptno 

-- 15. List the name and salary of employees who earn more than 1500 and are in department 10 or 30. Label the columns Employee and Monthly Salary respectively.
select ename as Employee,sal as 'Monthly Salary' from EMP where ((sal>1500) and (deptno=10 or deptno=30))



