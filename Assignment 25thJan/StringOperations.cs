using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2Part_1
{
    //Problem stmt
/*
 * 1.	Write a program in C# to accept a word from the user and display the length of it.
2.	Write a program in C# to accept a word from the user and display the reverse of it. 
3.	Write a program in C# to accept two words from user and find out if they are same. 
*/
class StringOperations
{
    static void Main()
    {
        int choice;
        string str;
        string astr;

        Console.WriteLine("Press 1: to find length of the string\nPress 2: to reverse string\nPress 3: to compare strings");
        Console.Write("Enter ur choice: ");
        choice = int.Parse(Console.ReadLine());
        if(choice==1)
        {
            Console.Write("Enter the string to find length: ");
            str = Console.ReadLine();
            Console.WriteLine("The length of the string is: "+str.Length);
        }
        else if(choice==2)
        {
            Console.Write("Enter the string to reverse it: ");
            str = Console.ReadLine();
            str=ReverseString(str);
            Console.WriteLine("Reversed string is: "+str);
        }
        else if(choice==3)
        {
            Console.Write("Enter string1: ");
            str = Console.ReadLine();

            Console.Write("Enter string2: ");
            astr = Console.ReadLine();

            if (String.Equals(str, astr))
                Console.WriteLine($"{str} and {astr} have same value.");
            else
                Console.WriteLine($"{str} and {astr} are different.");
        }
        else
        {
            Console.WriteLine("Invalid choice!!");
        }



    }
    public static string ReverseString(string str)
    {
        if (str.Length <= 1) return str;
        else return ReverseString(str.Substring(1)) + str[0];
    }

}
}
// output
/*
Press 1: to find length of the string
Press 2: to reverse string
Press 3: to compare strings
Enter ur choice: 1
Enter the string to find length: Krithika Sharma
The length of the string is: 15

Press 1: to find length of the string
Press 2: to reverse string
Press 3: to compare strings
Enter ur choice: 2
Enter the string to reverse it: Krithika Sharma
Reversed string is: amrahS akihtirK

Press 1: to find length of the string
Press 2: to reverse string
Press 3: to compare strings
Enter ur choice: 3
Enter string1: Krithika
Enter string2: Sharma
Krithika and Sharma are different.

Press 1: to find length of the string
Press 2: to reverse string
Press 3: to compare strings
Enter ur choice: 3
Enter string1: Krithika
Enter string2: krithika
Krithika and krithika are different.
*/