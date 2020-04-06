//Gillian Gauss
using System;

namespace April_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.Length = 5;
            r.Width = 8;

            double rArea = r.CalculateArea();
            double rPerimeter = r.CalculatePerimeter();
            Console.WriteLine($"The rectangle with {r.Length} length and {r.Width} width has an area of {rArea} and a perimeter or {rPerimeter}");

            Circle c = new Circle();
            c.Radius = 10;

            double cArea = c.CalculateArea();
            double cPerimeter = c.CalculatePerimeter();

            Console.WriteLine($"The circle with {c.Radius} radius has an area of {cArea} and a perimeter or {cPerimeter}");

            Console.ReadKey();

        }
    }
}
