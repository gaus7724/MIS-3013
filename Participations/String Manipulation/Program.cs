using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Manipulation
{
    class Program
    {
        static void Main(string[] args)
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
               for (int i = change.Length -1; i>=0; i --)
                { Console.Write(change[i]);
                        }
            }

            Console.ReadKey();
        }
    }
}
