using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


// problem stmt:
/*
6. Write a program in C# Sharp to insert the information of two books. 

Test Data :

Insert the information of two books :                    
-----------------------------------------                
Information of book 1 :                                  
Input name of the book : BASIC                           
Input the author : S.TROELSTRA                           
                                                         
Information of book 2 :                                  
Input name of the book : C+                              
Input the author : G.RTRTG   

                            
Expected Output:

1: Title = BASIC,  Author = S.TROELSTRA                  
                                                         
2: Title = C+,  Author = G.RT
*/
namespace Assignment_3_28thJan
{
    class BooksInfoArrayAssignment
    {
        struct bookDetails
        {
            public string author;
            public string title;
        }
        static void Main()
        {
            //ArrayList[][] al = new ArrayList[2][2];
            Console.Write("Enter the no. of books: ");
            int noOfBooks = Int32.Parse(Console.ReadLine());

            bookDetails[] bd = new bookDetails[noOfBooks];

            for (int i = 0; i < noOfBooks; i++)
            {
                Console.Write("Information of book{i}... \n");

                Console.Write("Input name of the book: ");
                bd[i].title= Console.ReadLine();
                Console.Write("Input the author: ");
                bd[i].author = Console.ReadLine();

                Console.WriteLine("\n");
            }
            foreach (var item in bd)
            {
                Console.WriteLine($"title: {item.title}, author: {item.author}"); // serial nos 1. 2. can be brought using for loop
            }
            Console.ReadKey();
        }
    }
}
// output
/*
Enter the no. of books: 2
Information of book{i}...
Input name of the book: Rich Dad Poor Dad
Input the author: Robert Kiyosaki


Information of book{i}...
Input name of the book: Atomic Habits
Input the author: James Clear


title: Rich Dad Poor Dad, author: Robert Kiyosaki
title: Atomic Habits, author: James Clear
*/
