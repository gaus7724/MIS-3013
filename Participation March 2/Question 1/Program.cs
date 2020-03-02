using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
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
    }
}
