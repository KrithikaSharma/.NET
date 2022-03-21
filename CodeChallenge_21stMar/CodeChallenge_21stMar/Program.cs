using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CodeChallenge_21stMar
{
    class Program
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        
        static void Main(string[] args)
        {
            getConn();
            Console.Write("Enter employee name: ");
            string ename = Console.ReadLine();
            Console.Write("Enter Employee Salary: ");
            double esal = Convert.ToDouble(Console.ReadLine());
            if(esal<25000)
            {
                Console.WriteLine("employee salary must be graeter than or equal to 25000");
                esal = 9999999; // for wrong condition
            }
            Console.Write("Enter empployee type('C'/'P'):");
            string etype = Console.ReadLine();
            if (!(etype.Equals("C") || etype.Equals("P")))
            {
                Console.WriteLine("Enter proper employee type");
            }

            cmd = new SqlCommand("add_employee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@empname", ename);
            cmd.Parameters.AddWithValue("@empsal", esal);
            cmd.Parameters.AddWithValue("@emptype", etype);

            dr = cmd.ExecuteReader();
            
            Console.WriteLine("record inserted successfully");
            Console.Read();
        }
        static SqlConnection getConn()
        {
            try
            {
                con = new SqlConnection("data source=MSI; initial catalog=EmployeeManagement; integrated security=true");
                con.Open();
            }
            catch(Exception e)
            {
                Console.WriteLine("Check Connection string");
                Console.WriteLine(e.Message);
            }
            return con;
        }
    }
}
