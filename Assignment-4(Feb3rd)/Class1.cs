using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cricket
{
    public class Class1
    {
        public static void PointsCalulation(int no_of_matches)
        {
            List<int> scores = new List<int>(10);
            int sum = 0;
            float avg = 0.0f;
            for (int i = 0; i < no_of_matches; i++)
            {
                Console.Write($"Enter score of match {i+1}:  ");
                int score = Convert.ToInt32(Console.ReadLine());
                scores.Add(score);
            }
            foreach (int sc in scores)
            {
                sum += sc;
            }
            avg = Convert.ToSingle(sum / no_of_matches);
            Console.WriteLine($"Sum of the scores played in {no_of_matches} matches is: {sum}");
            Console.WriteLine($"Average of the scores played in {no_of_matches} matches is: {avg}");
        }
    }
}

// output
/*
Enter no of matches played: 4
Enter score of match 1:  390
Enter score of match 2:  322
Enter score of match 3:  180
Enter score of match 4:  87
Sum of the scores played in 4 matches is: 979
Average of the scores played in 4 matches is: 244
*/
