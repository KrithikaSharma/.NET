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
select * from Emp
select * from DEPT


-- tasks
-- 1. List all employess whose name begins with 'A'
select ename from EMP where ename like 'A%'

-- 2. select all those employees who don't have a manager
select ename from EMP where mgr is null

--3. list employee name, number and salary for those employees who earn in the range 1200 to 1400
select ename,empno,sal from EMP where sal between 1200 and 1400

--4. Give all the employees in the RESEARCH department a 10% pay rise. Verify that this has been done by listing all their before and after the rise
-- select ename, sal, sal+sal*0.1 as 'updated salary' from EMP where EMP.deptno=(select deptno from DEPT where dname like 'RESEARCH')
update EMP set sal=(select sal+ (select sal*0.1)) where EMP.deptno=(select deptno from DEPT where dname like 'RESEARCH')

-- 5. Find the number of CLERKS employed. Give it a descriptive heading. 
select count(job) as 'no of clerks employed' from EMP where job like 'clerk'

-- 6. Find the average salary for each job type and the number of people employed in each job. 
select job,avg(sal) as 'avg salary',count(ename) as 'no of employees' from EMP group by job

-- 7. List the employees with the lowest and highest salary. 
select e.ename, e.sal
from emp e
where e.sal = (SELECT MAX(e2.sal) from emp e2) OR e.sal = (select MIN(e2.sal) from emp e2);

-- 8. List full details of departments that don't have any employees. 
select * from DEPT d where d.deptno not in (select deptno from EMP)

-- 9. Get the names and salaries of all the analysts earning more than 1200 who are based in department 20. Sort the answer by ascending order of name. 
select ename,sal,job from EMP where job='analyst' and sal>1200 and deptno=20 order by ename

-- 10. For each department, list its name and number together with the total salary paid to employees in that department. 
select d.dname, d.deptno, sum(e.sal) as 'total salary' from DEPT d,EMP e where d.deptno=e.deptno group by d.deptno,d.dname

-- 11. Find out salary of both MILLER and SMITH.
select ename, sal from EMP where ename='miller' or ename='smith'

-- 12. Find out the names of the employees whose name begin with ‘A’ or ‘M’.
select ename from EMP where ename like 'a%' or ename like 'm%'

-- 13. Compute yearly salary of SMITH.
--  question not clear ,if sal given is monthly it can be computed as salary*12
select ename, sal*12 as 'salary' from emp where ename='smith'

-- 14. List the name and salary for all employees whose salary is not in the range of 1500 and 2850.
select ename,sal from EMP where sal not between 1500 and 2850

