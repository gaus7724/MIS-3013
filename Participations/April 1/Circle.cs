using System;
using System.Collections.Generic;
using System.Text;

namespace April_1
{
    class Circle
    {
        public double Radius { get; set; }

        public Circle()
        {
            Radius = 0;
        }

        public double CalculateArea()
        {
           double PI = Math.PI;
            return PI * Radius * Radius;
        }

        public double CalculatePerimeter()
        {
            double PI = Math.PI;
            return 2 * PI * Radius;
        }

    }
}
