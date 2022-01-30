using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_28thJan
{
    /*
    4. Write a program in C# Sharp to declare a structure called Books with a property,
    a method to display the value of Book_id, and a private field called Book_id (int)
    */
    struct Books
    {
        private int Book_id { get; set; } 

        public int Bid
        {
            get { return Book_id; }
            set { Book_id = value; }
        }
        public void Display()
        {
            Console.WriteLine($"Book id is: {Book_id}");
        }
    }
    class StructureAssignment
    {
        static void Main()
        {
            Books b=new Books(); //implementing a structure is optional
            b.Bid = 2321;
            b.Display();
            Console.Read();
        }
    }
}
// output
/*
Book id is: 2321
*/
