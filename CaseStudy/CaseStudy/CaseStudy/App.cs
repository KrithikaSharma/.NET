using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    class App : AppEngine
    {
        static void HomePage()
        {
            Console.Clear();
            Console.WriteLine("---------      Welcome to Student Learning Portal      -------------");
            Console.WriteLine("Press 1: To login as Student");
            Console.WriteLine("Press 2: To login as Admin");
            Console.WriteLine("Press 0: To close this Application");
            int choice=1;
            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine("Invalid datatype entry...enter either 1 or 2");
                Console.WriteLine(e.Message);
                HomePage();
            }
            
            
            if (choice == 1)
            {
                Console.Write("Enter username: ");
                string un = Console.ReadLine();
                Console.Write("Enter password: ");
                string pswd = Console.ReadLine();
                if (pswd != "1234")
                {
                    Console.WriteLine(" **************          Incorrect password!!        *********************");
                }
                else
                {
                    int cont = 1;
                    while(cont==1)
                    {
                        Console.Clear();
                        Console.WriteLine("---      Welcome to student console  -----------");
                        Console.WriteLine("Press 1. To register a student");
                        Console.WriteLine("Press 2. To see available courses details");
                        Console.WriteLine("Press 3. To enroll into a course");
                        Console.WriteLine("Press 4. To return to home page");
                        int studch = Convert.ToInt32(Console.ReadLine());
                        switch (studch)
                        {
                            case 1:
                                Console.Write("Enter Student id: ");
                                int stid = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Enter Student name: ");
                                string stname = Console.ReadLine();
                                Console.Write("Enter date of birth(yyyy/mm/dd): ");
                                DateTime sdob = Convert.ToDateTime(Console.ReadLine());
                                Student s = new Student(stid, stname, sdob);
                                Register(s);
                                break;
                            case 2:
                                ListOfCourses();
                                break;
                            case 3:
                                Console.WriteLine(" ----    Select the course in which you want to enroll from the below list   ----------");
                                Enroll();
                                break;
                            case 4:
                                HomePage();
                                break;
                            default:
                                Console.WriteLine("Invalid choice!!");
                                break;
                        }

                        try
                        {
                            Console.Write("Do you want to continue(1(yes)/0(no): ");
                            cont = Convert.ToInt32(Console.ReadLine());
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine("Invalid datatype entry...enter either 1 or 0");
                            Console.WriteLine(e.Message);
                        }
                    }
                    
                }
            }
            else if(choice==2)
            {
                Console.Write("Enter username: ");
                string un = Console.ReadLine();
                Console.Write("Enter password: ");
                string pswd = Console.ReadLine();
                if (pswd != "0000")
                {
                    Console.WriteLine(" **************          Incorrect password!!        *********************");
                }
                else
                {
                    int cont=1;
                    while(cont==1)
                    {
                        Console.Clear();
                        Console.WriteLine("---      Welcome to Admin console  -----------");
                        Console.WriteLine("Press 1. To list available students");
                        Console.WriteLine("Press 2. To see available courses ");
                        Console.WriteLine("Press 3. To introduce a course");
                        Console.WriteLine("Press 4. To see the enrollments");
                        Console.WriteLine("Press 5. To return to home page");
                        // add code to modify/delete courses
                        //add code to delete courses

                        int adminch = Convert.ToInt32(Console.ReadLine());
                        switch (adminch)
                        {
                            case 1:
                                ListOfStudents();
                                break;
                            case 2:
                                ListOfCourses();
                                break;
                            case 3:
                                Console.Write("Enter course id: ");
                                int cid = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Enter course name: ");
                                string cname = Console.ReadLine();
                                Console.Write("Enter course duration in months: ");
                                int cdur = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Enter course fee: ");
                                int cfee = Convert.ToInt32(Console.ReadLine());
                                Course c = new Course(cid, cname, cdur, cfee);
                                Introduce(c);
                                break;
                            case 4:
                                listOfEnrollments();
                                break;
                            case 5:
                                HomePage();
                                break;
                            default:
                                Console.WriteLine("Invalid choice!!");
                                break;
                        }

                        Console.Write("Do you want to continue(1(yes)/0(no): ");
                        cont = Convert.ToInt32(Console.ReadLine());
                    }
                    
                }
            }
            else if(choice==0)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Invalid choice!!");
            }
        }
        static void Main(string[] args)
        {
            //Scenario1();
            //Scenario2();
            //Scenario3();

            HomePage();
            Console.Read();
        }

        public static void Scenario1()
        {
            Student s1 = new Student(501, "A.Ramya", Convert.ToDateTime("1998/11/10"));
            Info.Display(s1);

            Student s2 = new Student(532, "N.Vineeth", Convert.ToDateTime("2000 / 07 / 30"));
            Info.Display(s2);

            Student s3 = new Student(537, "Farah", Convert.ToDateTime("1999 / 12 / 13"));
            Info.Display(s3);

            //----------------------------------------------------------------------------
            Course c1 = new Course(900, "Azure fundamentals", 45, 100000);
            Info.Display(c1);

            Course c2 = new Course(204, "Azure developer", 30, 90850);
            Info.Display(c2);

            Course c3 = new Course(104, "Azure Administrator", 35, 65000);
            Info.Display(c3);
        }

        public static void Scenario2()
        {
            Student[] stuarr = new Student[3];

            stuarr[0] = new Student(510, "Sumalatha", Convert.ToDateTime("1999 / 01 / 22"));
            stuarr[1] = new Student(523, "S.Vinya", Convert.ToDateTime("1999 / 07 / 12"));
            stuarr[2] = new Student(517, "P.Akshaya", Convert.ToDateTime("2000 / 10 / 07"));

            // iterating over Student Array....and calling the display method for each student
            foreach (Student item in stuarr)
            {
                Info.Display(item);
            }

            //----------------------------------------------------------------------------
            Course[] carr = new Course[3];

            carr[0] = new Course(294, "Ansible", 50, 16500);
            carr[1] = new Course(180, "Openshift and kubernetes", 90, 56000);
            carr[2] = new Course(199, "RHCSA", 70, 20400);

            // iterating over Course Array....and calling the display method for each Course
            foreach (Course item in carr)
            {
                Info.Display(item);
            }
        }

        public static void Scenario3()
        {
            Console.WriteLine("Enter the no of students whose data u want to enter: ");
            int no_of_Stud = Convert.ToInt32(Console.ReadLine());
            Student[] st = new Student[no_of_Stud];
            for (int i = 0; i < no_of_Stud; i++)
            {
                Console.WriteLine($"Enter id for student{i + 1}: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Enter name for student{i + 1}: ");
                String name = Console.ReadLine();

                Console.WriteLine($"Enter dob for student{i + 1} in('YYYY/MM/DD'): ");
                DateTime dob = Convert.ToDateTime(Console.ReadLine());

                st[i] = new Student(id, name, dob);
            }

            foreach (Student item in st)
            {
                Info.Display(item);
            }


            //----------------------------------------------------------------------------
            Console.Write("Enter the no of courses whose data u want to enter: ");
            int no_of_crcs = Convert.ToInt32(Console.ReadLine());
            Course[] crs = new Course[no_of_crcs];
            for (int i = 0; i < no_of_crcs; i++)
            {
                Console.Write($"Enter course id for course{i + 1}: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.Write($"Enter course name for course{i + 1}: ");
                String name = Console.ReadLine();

                Console.Write($"Enter Duration for course{i + 1} (no of days): ");
                int dur = Convert.ToInt32(Console.ReadLine());

                Console.Write($"Enter course fee for course{i + 1}: ");
                int fe = Convert.ToInt32(Console.ReadLine());

                crs[i] = new Course(id, name, dur, fe);
            }

            foreach (Course item in crs)
            {
                Info.Display(item);
            }
        }
    }

}
