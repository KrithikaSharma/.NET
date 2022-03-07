using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    class AppEngine
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;

        static SqlConnection getConnection()
        {
            try
            {
                con = new SqlConnection("Data Source=MSI;Initial Catalog=CaseStudy;Integrated Security=True;MultipleActiveResultSets=True");
                con.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error in database connection!!");
                Console.WriteLine(e.Message);
            }
            
            return con;
            
        }

        public static void Introduce(Course course)
        {
            Console.Clear();
            con = getConnection();
            
            int c_id,c_dur,c_fee;
            string c_name;
            c_id = course.cid;
            c_name = course.cname;
            c_dur = course.duration;
            c_fee = course.fees;

            
            cmd = new SqlCommand("insert into Course values(@cid,@cname,@duration,@cfee)",con);
            
            cmd.Parameters.AddWithValue("@cid", c_id);
            cmd.Parameters.AddWithValue("@cname", c_name);
            cmd.Parameters.AddWithValue("@duration", c_dur);
            cmd.Parameters.AddWithValue("@cfee", c_fee);
            int courserows = cmd.ExecuteNonQuery();
            if (courserows > 0)
                Console.WriteLine("Course introduced sucessfully");
            else
                Console.WriteLine("Please enter valid course details");

        }
        
        public static void Register(Student student)
        {
            con = getConnection();
            int s_id=student.id;
            string s_name=student.name;
            DateTime s_dob=student._dateofbirth;
            cmd = new SqlCommand("insert into Student values (@stdid,@stdname,@dob)", con);
            cmd.Parameters.AddWithValue("@stdid", s_id);
            cmd.Parameters.AddWithValue("@stdname", s_name);
            cmd.Parameters.AddWithValue("@dob", s_dob);

            int res1 = cmd.ExecuteNonQuery();
            if (res1>0)
            {
                Console.WriteLine("Record inserted successfully...!");
            }
            else
            {
                Console.WriteLine("Some error encountered in database...");
            }

        }
        
        public static void ListOfStudents()
        {
            con = getConnection();
            Console.Clear();
            con = getConnection();
            cmd = new SqlCommand("Select *from Student", con);
            int res6 = cmd.ExecuteNonQuery();
            Console.WriteLine("Students available are...!");
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("Student Id : " + " " + dr[0]);
                Console.WriteLine("Student Name :" + " " + dr[1]);
                Console.WriteLine("Student Dateofbirth :" + " " + dr[2]);
                Console.WriteLine();
            }
            dr.Close();
            con.Close();
        }
        
        public static void ListOfCourses()
        {
            Console.Clear();
            con = getConnection();
            cmd = new SqlCommand("Select *from Course", con);
            int res6 = cmd.ExecuteNonQuery();
            Console.WriteLine("Courses Available In the Institution are...!");
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("Course Details : ");
                Console.WriteLine("--------------------------");
                Console.WriteLine("Course Id : " + " " + dr[0]);
                Console.WriteLine("Course Name :" + " " + dr[1]);
                Console.WriteLine("Course Duration :" + " " + dr[2]);
                Console.WriteLine("Course Fees :" + " " + dr[3]);
            }
            dr.Close();
            con.Close();
        }

        public static void Enroll()
        {
            Console.Clear();
            ListOfCourses();
            con = getConnection();
            Console.Write("Enter student id: ");
            int sid = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter course id: ");
            int cid = Convert.ToInt32(Console.ReadLine());
            DateTime EnrollDate = DateTime.UtcNow;
            cmd = new SqlCommand("insert into enroll values(@stdid,@cid,@enrollment)", con);
            cmd.Parameters.AddWithValue("@cid", cid);
            cmd.Parameters.AddWithValue("@stdid", sid);
            cmd.Parameters.AddWithValue("@enrollment", EnrollDate);
            int res5 = cmd.ExecuteNonQuery();
            if (res5 > 0)
            {
                Console.WriteLine("Student enrolled to the Course Sucessfully");
            }
            else
                Console.WriteLine("Please enter valid details");
        }

        public static void listOfEnrollments()
        {
            Console.Clear();
            con = getConnection();
            cmd = new SqlCommand("Select *from enroll", con);
            int res6 = cmd.ExecuteNonQuery();
            Console.WriteLine("Enrollment details are...!");
            dr = cmd.ExecuteReader();
            Console.WriteLine("Enrollment id \tStudent id\tCourseid\tEnrollment date");
            while (dr.Read())
            {
                Console.WriteLine($"{dr[0]}, \t{dr[1]},  {dr[2]},  {dr[3]}");
            }
            dr.Close();
            con.Close();
        }
        
    }
}
