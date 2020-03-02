//Gillian Gauss
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double examScore = 0;
            string answer = "";

            List<double> examScores = new List<double>();

            do
            {
                Console.WriteLine($"Please enter your exam score.");
                string examScoreAsString = Console.ReadLine();
                examScore = Convert.ToDouble(examScoreAsString);

                examScores.Add(examScore);


                Console.WriteLine($"Do you have another exam score to enter? (y or n)");
                answer = Console.ReadLine();

            } while (answer == "y");

            double sum = 0;

            foreach (var score in examScores)
            {
                sum = sum + score;


            }
            double average = sum / examScores.Count;

            Console.WriteLine($"The average of your exam scores is {average}");

            Console.ReadKey();
        }
    }
}
