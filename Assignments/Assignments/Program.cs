
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string canContinue = "y";
            int ch;

            Program p = new Program();
            while (canContinue.Equals("y") || canContinue.Equals("Y"))
            {
                Console.WriteLine("Press 1: To Greet User\nPress 2: To find if entered no is even or odd\nPress 3: To find the largest and smallest of 3 nos\nPress 4: To demostrate marks of 10 students for 3 subjects and its statistics\nPress 5: To convert fahrenheit to Celsius\nPress 6: To find min and max elements of an array\nPress 7: To do statistics on marks array ");
                Console.Write("Enter ur choice: ");
                ch=Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        p.GreetUser();
                        break;
                    case 2:
                        p.EvenOdd();
                        break;
                    case 3:
                        p.LargestSmallest();
                        break;
                    case 4:
                        assignment4();
                        break;
                    case 5:
                        p.Temparature();
                        break;
                    case 6:
                        p.MinMaxArray();
                        break;
                    case 7:
                        p.MarksArr();
                        break;
                    default:
                        Console.WriteLine("Invalid Choice!!Try Again");
                        break;
                }
                Console.Write("Do you want to continue(y/n): ");
                canContinue = Convert.ToString(Console.ReadLine());
            }

            void assignment4()
            {
                PassFail stud1 = new PassFail(84, 72, 21);
                stud1.Result();


                PassFail stud2 = new PassFail(67, 13, 35);
                stud2.Result();

                PassFail stud3 = new PassFail(78, 86, 33);
                stud3.Result();

                PassFail stud4 = new PassFail(53, 87, 20);
                stud4.Result();

                PassFail stud5 = new PassFail(46, 16, 17);
                stud5.Result();
            }
        }

        public void GreetUser()
        {
            string username;
            Console.Write("Enter Username: ");
            username = Console.ReadLine();
            Console.WriteLine("Hi! {0} \nWelcome to the world of C#", username);
        }

        public void EvenOdd()
        {
            int no;
            Console.Write("Enter positive integer: ");
            bool isInt = Int32.TryParse(Console.ReadLine(), out no); //storing in no variable again
            
            
            if (isInt && no%2==0)
            {
                Console.WriteLine("Entered no: {0} is EVEN!!",no);
            }
            else if (isInt && no%2!=0)
            {
                Console.WriteLine("Entered no: {0} is ODD!!", no);
            }
            else
            {
                Console.WriteLine("Invalid!!");
            }
        }
        public void LargestSmallest()
        {
            int a, b, c;
            Console.WriteLine("Enter 3 nos: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            // for smallest
            if(a<b && a<c)
            {
                Console.WriteLine("{0} is smallest",a);
            }
            else if(b<c)
            {
                Console.WriteLine("{0} is smallest",b);
            }
            else
            {
                Console.WriteLine("{0} is smallest", c);
            }

            // for largest
            if (a > b && a > c)
            {
                Console.WriteLine("{0} is largest", a);
            }
            else if (b > c)
            {
                Console.WriteLine("{0} is largest", b);
            }
            else
            {
                Console.WriteLine("{0} is largest", c);
            }
        }

        class PassFail
        {
            int CSharp;
            int HTML;
            int Sql;

            public PassFail(int a,int b,int c)
            {
                CSharp = a;
                HTML = b;
                Sql = c;
            }

            public void Result()
            {
                int sum;
                float avg;
                sum = CSharp + HTML + Sql;
                avg = sum / 3;
                if (avg>50)
                {
                    Console.WriteLine("You Passed, Congratulations!! \nYou scored {0} in CSharp,\n{1} in HTML,\n{2} in Sql",CSharp,HTML,Sql);
                }
                else
                {
                    Console.WriteLine("Need to score above 50% to pass, Try Again!!\nYou scored {0} in CSharp,\n{1} in HTML,\n{2} in Sql", CSharp, HTML, Sql);
                }
            }

        }

        public void Temparature()
        {
            Double fahrenheit, celsius;
            Console.Write("Enter Temparature in Fahrenheit: ");
            fahrenheit = Convert.ToDouble(Console.ReadLine());
            celsius = ((fahrenheit - 32) / 1.8);
            Console.WriteLine("Temparature is {0} degree Celcius",Math.Round(celsius,1));
        }

        public void MinMaxArray()
        {
            int noOfEle;
            float arrSum=0,arrAvg = 0f;
            Console.Write("Enter no. of elements of an array: ");
            noOfEle=Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[noOfEle];
            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < noOfEle; i++)
            {
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(arr);
            foreach (var item in arr)
            {
                arrSum += item;
            }
            arrAvg = (arrSum / noOfEle);
            Console.WriteLine("Sum of array elements: "+arrSum);
            Console.WriteLine("Average of array elements is: {0}",arrAvg);
            Console.WriteLine("Minimum value in the array: {0}\nMaximum value in the array: {1}",arr[0],arr[noOfEle-1]);

        }

        public void MarksArr()
        {
            int[] marks = new int[10];
            float TotMarks = 0, marksAvg = 0f;
            Console.WriteLine("Enter marks of 10 subjects: ");
            for (int i = 0; i < 10; i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(marks);
            foreach (var item in marks)
            {
                TotMarks += item;
            }
            marksAvg = TotMarks / 10;
            Console.WriteLine("Total marks scored by a student in 10 subjects: {0}\nAverage of 10 subjects is: {1}\nLeast mark scored is: {2}\nHighest mark scored is: {3}", TotMarks, marksAvg, marks[0], marks[9]);
            Console.WriteLine("Marks in ascending order...");
            foreach (var item in marks)
            {
                Console.WriteLine(item);
            }

            Array.Reverse(marks);
            Console.WriteLine("Marks in descending order...");
            foreach (var item in marks)
            {
                Console.WriteLine(item);
            }
        }
    }
}
