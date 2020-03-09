//Gillian Gauss
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace March_9_Participation
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "";
            do
            {
                Console.WriteLine("What type of calculation do you want to perform? (add, subtract, multiply, divide)");
                string calcType = Console.ReadLine();

                Console.WriteLine("Please enter your first number");
                string num1asString = Console.ReadLine();
                double num1 = Convert.ToDouble(num1asString);

                Console.WriteLine("Please enter your second number");
                string num2asString = Console.ReadLine();
                double num2 = Convert.ToDouble(num2asString);

                if (calcType == "add")
                {
                    double addTotal = addition(num1, num2);
                    Console.WriteLine($"Your total is {addTotal}");
                }
                else if (calcType == "subtract")
                {
                    double subtractTotal = subtract(num1, num2);
                    Console.WriteLine($"Your total is {subtractTotal}");
                }
                else if (calcType == "multiply")
                {
                    double multiplyTotal = multiply(num1, num2);
                    Console.WriteLine($"Your total is {multiplyTotal}");
                }
                else
                {
                    double divideTotal = divide(num1, num2);
                    Console.WriteLine($"Your total is {divideTotal}");
                }
                Console.WriteLine($"Do you want to perform another calculation? (y or n)");
                answer = Console.ReadLine();

            } while (answer == "y");

            Console.WriteLine($"Thank you for using our service. Press any key to exit.");
    
            Console.ReadKey();
        }

        static double addition(double num1, double num2)
        {
            return num1 + num2;

        }

        static double subtract(double num1, double num2)
        {
            return num1 - num2;

        }
        static double multiply(double num1, double num2)
        {
            return num1 * num2;

        }
        static double divide(double num1, double num2)
        {
            return num1 / num2;

        }

        static void DeveloperInformation(string developerName, string className, string dateOfWriting)
        {
            developerName = "Gillian Gauss";
            className = "MIS3013";
            dateOfWriting = "March 9, 2020";
            Console.WriteLine($"{developerName} wrote this application for {className} on {dateOfWriting}");
        }
    }

}
