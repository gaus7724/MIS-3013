//Gillian Gauss
using System;

namespace TaxRate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first and last name.");
            string userName = Console.ReadLine();

            Console.WriteLine("Please enter your salary.");
            string salaryAsString = Console.ReadLine();
            double salary = Convert.ToDouble(salaryAsString);

            double fedWithheld = CalculateFederalTaxRate(salary);
            double FICAWithheld = CalculateFICATax(salary);

            DisplayResults(userName, salary, fedWithheld, FICAWithheld);


            Console.ReadKey();
        }

        static double CalculateFederalTaxRate(double salary)
        {
            double TaxRate = 0;
            if (salary <= 9525)
            {
                TaxRate = .1;
            }
            else if (salary <= 38700)
            {
                TaxRate = .12;
            }
            else if (salary <= 82500)
            {
                TaxRate = .22;
            }
            else if (salary <= 157500)
            {
                TaxRate = .24;
            }
            else if (salary <= 200000)
            {
                TaxRate = .32;
            }
            else if (salary <= 500000)
            {
                TaxRate = .35;
            }
            else if (salary > 500000)
            {
                TaxRate = .37;
            }
            return (TaxRate * salary);
        }

        static double CalculateFICATax(double salary)
        {
            return salary * .062;
        }

        static void DisplayResults(string userName, double salary, double fedWithheld, double FICAWithheld)
        {
            double netSalary = salary - fedWithheld - FICAWithheld;
            Console.WriteLine($"{userName} your salary of {salary.ToString("C0")} with have {fedWithheld.ToString("C0")} withheld for Federal Taxes and {FICAWithheld.ToString("C0")} for FICA Taxes.");
            Console.WriteLine($"This gives you a net salary of {netSalary.ToString("C0")}");

        }
    }

}

