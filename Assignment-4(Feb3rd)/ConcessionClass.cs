using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcessionAssignment
{
    public class ConcessionClass
    {
        int age;
        public ConcessionClass(int a)
        {
            age = a;
        }

        public static void CalculateConcession(int age, int totalfare)
        {
            
            float cnssn;
            if (age<=5)
            {
                Console.WriteLine("Little Champs - Free Ticket");
            }
            else if(age>60)
            {
                cnssn = (float)(0.3 * totalfare);
                Console.WriteLine($"Senior Citizen - {totalfare- Math.Round(cnssn,2)}/-");
            }
            else if((age>6) && (age<=60))
            {
                Console.WriteLine($"Ticked Booked: {totalfare}/-");
            }

            else
            {
                Console.WriteLine("Enter appropriate age");
            }

        }
    }
}
// further enhancements: like enter no of tickets u want to purchase take loop add ages give total fare
//output
/*
Enter age for purchasing ticket: 4
Little Champs - Free Ticket

Enter age for purchasing ticket: 50
Ticked Booked: 850/-

Enter age for purchasing ticket: 63
Senior Citizen - 595/-



*/

