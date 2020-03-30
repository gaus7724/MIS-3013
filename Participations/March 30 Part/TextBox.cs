using System;
using System.Collections.Generic;
using System.Text;

namespace March_30_Part
{
    class TextBox
    {
        public int Padding { get; set;}

        public ConsoleColor BackColor { get; set;}

        public ConsoleColor ForeColor { get; set; }

        public String Text { get; set; }

        public TextBox()
        {
            Padding = 1;
            BackColor = ConsoleColor.Black;
            ForeColor = ConsoleColor.White;
            Text = "sample text";
        }

        public void DisplayText()
        {
            string space = " ";

            Console.ForegroundColor = ForeColor;
            Console.BackgroundColor = BackColor;

            for (int i = 0; i < Padding; i++)
            {
                space = space + " ";
            }
            Console.WriteLine(Text);
        }

    }
}
