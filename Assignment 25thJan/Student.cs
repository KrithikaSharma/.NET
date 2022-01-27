using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Assignment_2Part_1
{
    /*
     Program Objective:
    2. Create a class called student which has data members like rollno, name, class, SEM, branch,int [] marks=new int marks [5](marks of 5 subjects )
        -Write a method called displayresult, which should calculate the average marks
        -If marks of any one subject is less than 35 print result as failed
        -If marks of all subject is >35 but average is < 50 then also print result as failed
        -If avg > 50 then print result as passed.
        -Pass the details of student like rollno, name, class, SEM, branch in constructor
        -Write a Display Data method to display all values.
     */
    class Student
    {
        int rollno;
        string name;
        int cls;
        int sem;
        string branch;
        int[] marks = new int[5];
        string result;
        float avg;
        int sum = 0;

        public Student(int rno, string n, int Scls, int sem, string brnch, int[] mrks)
        {
            rollno = rno;
            name = n;
            cls = Scls;
            this.sem = sem;
            branch = brnch;
            marks = mrks;
        }

        public void DisplayResult()
        {
            for (int i = 0; i < marks.Length; i++)
            {
                sum += marks[i];
            }
            avg = sum / 5;
            for (int i = 0; i < marks.Length; i++)
            {

                if ((marks[i] < 35) || (avg < 50)) 
                {
                    result = "failed";
                }
            
                
                else if(avg>50)
                {
                    result = "passed";
                }
            }
        }

        public void Display()
        {
            Console.WriteLine($"Roll No: {rollno},\nname: {name},\nclass: {cls},\nsem: {sem},\nbranch: {branch},");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine($"Marks of subject {i+1} are {marks[i]}");
            }
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("And the result is.....");
            if(result.Equals("failed"))
            {
                Console.WriteLine("oh no you have failed, u need to have avg of 50 and marks above 35 in each subject to pass");
            }
            else if(result.Equals("passed"))
            {
                Console.WriteLine($"Congratulations!!! You Passed!!!!!!\nYour Score is: {sum} and avg is: {avg}");
            }
        }
        static void Main()
        {   
            Student s = new Student(101, "KriSh", 2, 8, "cse",new int[] {37,38, 36, 38, 39 }); //can take input from user too if needed 
            s.DisplayResult();
            s.Display();
            
            Student s1 = new Student(104, "krithi", 3, 6, "ece", new int[] { 73, 83, 63, 30, 100 }); 
            s1.DisplayResult();
            s1.Display();

            Student s2 = new Student(105, "Sharma", 1, 7, "civil", new int[] { 73, 83, 63, 38, 100 });
            s2.DisplayResult();
            s2.Display();
            Console.ReadLine();
        }
    }
}
/* resultant output:
Roll No: 101,
name: KriSh,
class: 2,
sem: 8,
branch: cse,    
Marks of subject 1 are 37
Marks of subject 2 are 38
Marks of subject 3 are 36
Marks of subject 4 are 38
Marks of subject 5 are 39
--------------------------------------------------------------------------
And the result is.....
oh no you have failed, u need to have avg of 50 and marks above 35 in each subject to pass

Roll No: 104,
name: krithi,
class: 3,
sem: 6,
branch: ece,
Marks of subject 1 are 73
Marks of subject 2 are 83
Marks of subject 3 are 63
Marks of subject 4 are 30
Marks of subject 5 are 100
--------------------------------------------------------------------------
And the result is.....
Congratulations!!! You Passed!!!!!!
Your Score is: 349 and avg is: 69

Roll No: 105,
name: Sharma,
class: 1,
sem: 7,
branch: civil,
Marks of subject 1 are 73
Marks of subject 2 are 83
Marks of subject 3 are 63
Marks of subject 4 are 38
Marks of subject 5 are 100
--------------------------------------------------------------------------
And the result is.....
Congratulations!!! You Passed!!!!!!
Your Score is: 357 and avg is: 71
*/
