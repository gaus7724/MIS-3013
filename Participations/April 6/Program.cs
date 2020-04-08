//Gillian Gauss
using System;

namespace April_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Student S1 = new Student();
            S1.CourseNames.Add("MIS3013");
            S1.CourseGrades.Add("A");

            S1.CalculateGPA();

            Student S2 = new Student();
            S2.CourseNames.Add("ACCT2113");
            S2.CourseGrades.Add("B");

            S2.CalculateGPA();

            Console.ReadKey();
        }
    }
}
