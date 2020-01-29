using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Participations
{
    class Program
    {
        static void Main(string[] args)
        {
            //if value is 1 then = heads
            string Choice;
            String winLose;
            Console.WriteLine("Pick heads or tails");
            Choice = Console.ReadLine();

            int userChoice;

            if (Choice == "heads")
            {
                userChoice = 1;
            }
            else
            {
                userChoice = 2;
            }



            Random rand = new Random();
            int rnd = rand.Next(1, 3);


            String results;
            if (rnd == 1)


            { results = "heads"; }
            else
            {
                results = "tails";
            }

            if (userChoice == rnd)
            {
                winLose = "You won!";
            }
            else
            {
                winLose = "Bummer. You lost";
            }
            Console.WriteLine(winLose);

            Console.WriteLine("The result of the toss is " + results);

            Console.ReadKey();
        }
    }
}

