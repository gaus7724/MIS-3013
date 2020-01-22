using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables3
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a string named firstName
            string firstName;

            //assign a value to firstName (use your name)
            firstName = "Gillian";

            //create an int named favoriteNumber and assign your favorite number to it
            int favoriteNumber = 21;

            double crazyNumber = 7.6767 * favoriteNumber;

            string lastName = "Gauss";

            string fullName = firstName + " " + lastName;

            Console.WriteLine(fullName + " has the favorite number of " + favoriteNumber + "" +
                "\nwhich equates to a crazy number of " + crazyNumber);

            //MAKE IT DYNAMIC

            Console.WriteLine("Please enter your first name: >>");
            firstName = Console.ReadLine();
           
            Console.WriteLine("Please enter your last name: >>");
           lastName = Console.ReadLine();

            string fullName = firstName + " " + lastName;

            Console.WriteLine("Please enter your favorite number: >>");
            String favoriteNumberAsString = Console.ReadLine();
            // favoriteNumber = Convert.ToInt32(favoriteNumberAsString);
            //favoriteNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(fullName + " has the favorite number of " + favoriteNumber + "" +
                "\nwhich equates to a crazy number of " + crazyNumber);

            //Console.WriteLine($"{fullName} has the favorite number of {favoriteNumber} \nwhich equates to a crazy number of {crazyNumber}");

            Console.ReadKey();
        }
    }
}
