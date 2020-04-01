using System;
using System.Collections.Generic;
using System.Text;

namespace April_1
{
    class Rectangle
    {
        public double Length {get; set;}

        public double Width { get; set; }

        public Rectangle ()
        {
            Length = 3;
            Width = 5;
        }

        public double CalculateArea()
        {
            return Length * Width;
        }

        public double CalculatePerimeter()
        {
            return 2 * (Length + Width);

        }


    }
}
