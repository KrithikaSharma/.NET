using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2Part_1
{
    //Problem stmt
    /*
     3.Create an Abstract class Student with  Name, StudentId, Grade as members and also an abstract method Boolean Ispassed(grade) which takes grade as an input and checks whether student passed the course or not.  

Create 2 Sub classes Undergraduate and Graduate that inherits all members of the student and overrides Ispassed() method 

For the UnderGrad class, if the grade is above 70.0, then isPassed returns true, otherwise it returns false. For the Grad class, if the grade is above 80.0, then isPassed returns true, otherwise returns false.
*/
    abstract class StudentClass
    {
        public string Name;
        public int StudentId;
        public float Grade;

        public void GetValues(string n, int sid, float g)
        {
            Name = n;
            StudentId = sid;
            Grade = g;
        }
        abstract public bool Ispassed();
    }

    class Undergraduate : StudentClass
    {
        
        public override bool Ispassed()
        {
            if (Grade > 70.0f)
            {
                return true;
            }
            else
                return false;
        }
    }
    class Graduate : StudentClass
    {
        public override bool Ispassed()
        {
            if (Grade > 80.0f)
                return true;
            else
                return false;
        }
    }
    class AbstractClass
    {
        static void Main()
        {
            String name;
            int stdid;
            float sgrade;
            string ug_or_g;

            Console.Write("Enter student name: ");
            name = Console.ReadLine();
            Console.Write("Enter Student id:");
            stdid = int.Parse(Console.ReadLine());
            Console.Write("Enter grade: ");
            sgrade = float.Parse(Console.ReadLine());
            Console.Write("type 'ug' for undergrad and g for graduate: ");
            ug_or_g = Console.ReadLine();

            if(ug_or_g.Equals("ug"))
            {
                Undergraduate u = new Undergraduate();
                u.GetValues(name, stdid, sgrade);
                bool result = u.Ispassed();
                if (result.Equals(true))
                {
                    Console.WriteLine("Congratulations!! u passed");
                }
                else if (result.Equals(false))
                {
                    Console.WriteLine("Failed!!");
                }
            }
            
            else if(ug_or_g.Equals("g"))
            {
                Graduate g = new Graduate();
                g.GetValues(name, stdid, sgrade);
                bool result = g.Ispassed();
                if (result.Equals(true))
                {
                    Console.WriteLine("Congratulations!! u passed");
                }
                else if (result.Equals(false))
                {
                    Console.WriteLine("Failed!!");
                }
            }   
        }
    }
}
//Resultant output
/*
Enter student name: Krithika
Enter Student id:536
Enter grade: 76.43
type 'ug' for undergrad and g for graduate: ug
Congratulations!! u passed

Enter student name: Sharma
Enter Student id:156
Enter grade: 76.43
type 'ug' for undergrad and g for graduate: g
Failed!!
*/