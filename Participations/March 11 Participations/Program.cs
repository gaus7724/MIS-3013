//Gillian Gauss
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace March_11_Participations
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "";

            Console.WriteLine($"Which participation do you ant to run? (March2, String Manipulation, or All)");
            answer = Console.ReadLine();

            if (answer == "March2")
            {
                FunctionMarch2();
            }
            else if (answer == "String Manipulation")
            {
                FunctionStringManipulation();
            }
            else
            {
                FunctionAll();
            }


        }

       static void FunctionMarch2()
        {
            string cs1 = "";
            string cs2 = "";
            string cs3 = "";
            string cn1 = "";
            string cn2 = "";
            string cn3 = "";


            Console.WriteLine("Please enter your first course subject.");
            cs1 = Console.ReadLine();

            Console.WriteLine("Please enter your second course subject.");
            cs2 = Console.ReadLine();

            Console.WriteLine("Please enter your third course subject.");
            cs3 = Console.ReadLine();

            Console.WriteLine("Please enter your first course number");
            cn1 = Console.ReadLine();

            Console.WriteLine("Please enter your second course number");
            cn2 = Console.ReadLine();

            Console.WriteLine("Please enter your third course number");
            cn3 = Console.ReadLine();

            string[] subjectArray = { cs1, cs2, cs3 };
            string[] numberArray = { cn1, cn2, cn3 };

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(subjectArray[i] + numberArray[i]);
            }

            Console.ReadKey();
        }

      static void  FunctionStringManipulation()
        {
            string sent = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning";
            string word;
            string change;

            Console.WriteLine(sent);
            Console.WriteLine("what word do you want to look for in the above sentence?");
            word = Console.ReadLine();
            Console.WriteLine("What word would you like to change it to?");
            change = Console.ReadLine();


            if (sent.Contains(word))
            {
                var newsent = sent.Replace(word, change);
                Console.WriteLine(newsent);
            }

            else
            {
                Console.WriteLine("Sorry, I could not find your word" + word + ".");
                for (int i = change.Length - 1; i >= 0; i--)
                {
                    Console.Write(change[i]);
                }
            }

            Console.ReadKey();
        }

        static void FunctionAll()
        {
            FunctionMarch2();
            FunctionStringManipulation();

        }

          
        }
    }



