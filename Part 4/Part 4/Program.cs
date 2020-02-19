//Gillian Gauss
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Double scores;
            string scoreAsString;
            string answer;
            double max = 0;
            double min = 1000;
            double totals = 0;
            double avgScore;

            List<double> scoreList = new List<Double>();



            do
            {
                Console.WriteLine("Please enter your test scores.");
                scoreAsString = Console.ReadLine();
                scores = Convert.ToInt32(scoreAsString);
                scoreList.Add(scores);

                if (scores > max)
                {
                    max = scores;
                }

                if (scores < min)
                {
                    min = scores;
                }

               Console.WriteLine("Do you have more test scores to enter? Y or N. ");
                answer = Console.ReadLine();

            } while (answer.ToUpper() == "Y" );

            for (int i = 0; i < scoreList.Count; i++)
            {
                totals = totals + scoreList[i];
              
            }
            avgScore = totals / scoreList.Count;

            Console.WriteLine("Your test score average is " + avgScore);
            Console.WriteLine("Your minimum test score is " + min);
            Console.WriteLine("Your maximum test score is " + max);

            Console.ReadKey();
        }
    }
}
