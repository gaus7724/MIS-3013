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

            Console.ReadKey();
        }
    }
}
