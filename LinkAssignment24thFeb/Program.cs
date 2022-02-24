using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment24thFeb
{
    public class Employee
    {
        public int EmployeeId;
        public string FirstName, LastName, Title, City;
        public DateTime DOB, DOJ;
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emplist = new List<Employee>();
            emplist.Add(new Employee { EmployeeId = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB = new DateTime(1984, 11, 16), DOJ = new DateTime(2011, 6, 8), City = "Mumbai" });
            emplist.Add(new Employee { EmployeeId = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB = new DateTime(1984, 08, 20), DOJ = new DateTime(2012, 7, 7), City = "Mumbai" });
            emplist.Add(new Employee { EmployeeId = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DOB = new DateTime(1987, 11, 14), DOJ = new DateTime(2015, 4, 12), City = "Pune" });
            emplist.Add(new Employee { EmployeeId = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1990, 6, 3), DOJ = new DateTime(2016, 2, 2), City = "Pune" });
            emplist.Add(new Employee { EmployeeId = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1991, 3, 8), DOJ = new DateTime(2016, 2, 2), City = "Mumbai" });
            emplist.Add(new Employee { EmployeeId = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant", DOB = new DateTime(1989, 11, 7), DOJ = new DateTime(2014, 8, 8), City = "Chennai" });
            emplist.Add(new Employee { EmployeeId = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DOB = new DateTime(1989, 12, 2), DOJ = new DateTime(2015, 1, 6), City = "Mumbai" });
            emplist.Add(new Employee { EmployeeId = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate", DOB = new DateTime(1993, 11, 11), DOJ = new DateTime(2014, 11, 6), City = "Chennai" });
            emplist.Add(new Employee { EmployeeId = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB = new DateTime(1992, 8, 12), DOJ = new DateTime(2014, 12, 3), City = "Chennai" });
            emplist.Add(new Employee { EmployeeId = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB = new DateTime(1991, 4, 12), DOJ = new DateTime(2016, 1, 2), City = "Pune" });
            
            Console.WriteLine("Displaying details of all employees...");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            var details = from emp in emplist
                          select emp;
            foreach(var item in details)
            {
                Console.WriteLine($"{item.EmployeeId}  {item.FirstName}   {item.LastName}   {item.Title}      {item.DOB}       {item.DOJ}    {item.City}");
            }
            
            Console.WriteLine("\n\nb. Display details of all the employee whose location is not Mumbai");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            var empNotMum=from emp in emplist
            where !(emp.City.Contains("Mumbai"))
            select emp;
            foreach (var item in empNotMum)
            {
                Console.WriteLine($"{item.EmployeeId}  {item.FirstName}   {item.LastName}   {item.Title}      {item.DOB}       {item.DOJ}    {item.City}");
            }
            
            Console.WriteLine("\n\nc. Display details of all the employee whose title is AsstManager");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            var empTitAssMgr = from emp in emplist
                            where emp.Title.Contains("AsstManager")
                            select emp;
            foreach (var item in empTitAssMgr)
            {
                Console.WriteLine($"{item.EmployeeId}  {item.FirstName}   {item.LastName}   {item.Title}      {item.DOB}       {item.DOJ}    {item.City}");
            }

            Console.WriteLine("\n\nd. Display details of all the employee whose Last Name start with S");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            var empLN_s = from emp in emplist
                               where emp.LastName.StartsWith("S")
                               select emp;
            foreach (var item in empLN_s)
            {
                Console.WriteLine($"{item.EmployeeId}  {item.FirstName}   {item.LastName}   {item.Title}      {item.DOB}       {item.DOJ}    {item.City}");
            }
            
            Console.WriteLine("\n\ne.Display a list of all the employee who have joined before 1 / 1 / 2015");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            var empJoinb4_2015 = from emp in emplist
                          where emp.DOJ<DateTime.Parse("1/1/2015")
                          select emp;
            foreach (var item in empJoinb4_2015)
            {
                Console.WriteLine($"{item.EmployeeId}  {item.FirstName}   {item.LastName}   {item.Title}      {item.DOB}       {item.DOJ}    {item.City}");
            }
            
            Console.WriteLine("\n\nf.Display a list of all the employee whose date of birth is after 1 / 1 / 1990");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            var empDobA1990 = from emp in emplist
                                 where emp.DOB < DateTime.Parse("1/1/1990")
                                 select emp;
            foreach (var item in empDobA1990)
            {
                Console.WriteLine($"{item.EmployeeId}  {item.FirstName}   {item.LastName}   {item.Title}      {item.DOB}       {item.DOJ}    {item.City}");
            }
            
            Console.WriteLine("\n\ng.Display a list of all the employee whose designation is Consultant and Associate");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            var empDesgConNAss = from emp in emplist
                              where ((emp.Title.Contains("Consultant")) || (emp.Title.Contains("Associate")))
                              select emp;
            foreach (var item in empDesgConNAss)
            {
                Console.WriteLine($"{item.EmployeeId}  {item.FirstName}   {item.LastName}   {item.Title}      {item.DOB}       {item.DOJ}    {item.City}");
            }

            Console.WriteLine("\n\nh. Display total number of employees");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            var empCount= (from emp in emplist
                          select emp).Count();
            Console.WriteLine("Total no of employees: "+Convert.ToInt32(empCount));
            

            Console.WriteLine("\n\ni. Display total number of employees belonging to 'Chennai'");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            var empchennai = (from emp in emplist
                            where emp.City.Contains("Chennai")
                            select emp).Count();
            Console.WriteLine("Total no of employees from chennai: " + Convert.ToInt32(empchennai));
            
            Console.WriteLine("\n\nj. Display highest employee id from the list");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            var empidhigh = (from emp in emplist
                             select emp.EmployeeId).Max();
            Console.WriteLine("highest employee id: " + Convert.ToInt32(empidhigh));
            
            Console.WriteLine("k.Display total number of employee who have joined after 1 / 1 / 2015");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            var empJoinA_2015 = from emp in emplist
                                where emp.DOJ > DateTime.Parse("1/1/2015")
                                select emp;
            foreach (var item in empJoinA_2015)
            {
                Console.WriteLine($"{item.EmployeeId}  {item.FirstName}   {item.LastName}   {item.Title}      {item.DOB}       {item.DOJ}    {item.City}");
            }
            
            Console.WriteLine("\n\nl. Display total number of employee whose designation is not “Associate");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            var empcountNotAssociate= (from emp in emplist
                                      where !(emp.Title.Contains("Associate"))
                                      select emp).Count();
            Console.WriteLine("total number of employee whose designation is not Associate: "+empcountNotAssociate);
            
            Console.WriteLine("\n\nm. Display total number of employee based on City");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            var groupedEmploeesByCity = emplist.GroupBy(x => x.City).Select(x => new { City = x.Key, EmployeesCount = x.Count() });
            foreach (var item in groupedEmploeesByCity)
            {
                Console.WriteLine($"{item.City}  {item.EmployeesCount}");
            }
            
            Console.WriteLine("\n\nn. Display total number of employee based on city and title");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            var grpempCitynTitle = from emp in emplist
                                   group emp by new { emp.City, emp.Title } into g
                                   select new { g.Key.City, g.Key.Title, MyCount = g.Count() };
            foreach (var item in grpempCitynTitle)
            {
                Console.WriteLine($"{item.City}  {item.Title}  {item.MyCount}");
            }

            Console.WriteLine("\n\no.Display total number of employee who is youngest in the list");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            var empyng = from emp in emplist
                      where emp.DOB == ((from emp1 in emplist select emp1.DOB).Max())
                      select emp;
            foreach (var item in empyng)
            {
                Console.WriteLine($" {item.FirstName}  {item.DOB}");
            }
                

            Console.Read();

        }
    }
}

