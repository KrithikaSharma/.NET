using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// problem stmt:
/*
5. Write a program in C# Sharp to create a nested structure to store two data for an employee in an array. 

Test Data:

Create a nested structure and store data in an array :                              
-------------------------------------------------------                          
Name of the employee : H.Rana                                                    
Input day of the birth : 05                                                      
Input month of the birth : 02                                                    
Input year for the birth : 58                                                    
                                                                                 
Name of the employee : S.Mathur                                                  
Input day of the birth : 04                                                      
Input month of the birth : 08                                                    
Input year for the birth : 59 
*/
namespace Assignment_3_28thJan
{
class NestedStructureEmpArrAssignment
{
    struct EmployeeRecords
    {
        public string EmpName;
        public DateOfBirth dob;
    }
    struct DateOfBirth
    {
        public int day;
        public int month;
        public int year;
    }

    static void Main()
    {
        EmployeeRecords[] er = new EmployeeRecords[2];
        for (int i = 0; i < 2; i++) // since no of records are 2
        {
            Console.Write("Name of the employee: ");
            string name = Console.ReadLine();
            er[i].EmpName = name;


            Console.Write("Input day of the birth: ");
            int dd = Convert.ToInt32(Console.ReadLine());
            er[i].dob.day = dd;

            Console.Write("Input month of the birth: ");
            int mm = Convert.ToInt32(Console.ReadLine());
            er[i].dob.month = mm;

            Console.Write("Input year for the birth: ");
            int yy = Convert.ToInt32(Console.ReadLine());
            er[i].dob.year = yy;


            Console.WriteLine("\n\n");
        }
    }
}
}
// output
/*
Name of the employee: S. Krithika Sharma
Input day of the birth: 30
Input month of the birth: 07
Input year for the birth: 1999



Name of the employee: Simi Lisa
Input day of the birth: 23
Input month of the birth: 10
Input year for the birth: 2000
*/
