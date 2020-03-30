//Gillian Gauss
using System;

namespace March_30_Part
{
    class Program
    {
        static void Main(string[] args)
        {
            TextBox TB1 = new TextBox();
            TB1.Padding = 3;
            TB1.Text = "This is the first text box.";
            TB1.BackColor = ConsoleColor.Yellow;
            TB1.ForeColor = ConsoleColor.Red;


            TB1.DisplayText();

            TextBox TB2 = new TextBox();
            TB2.Padding = 5;
            TB2.Text = "This is the second text box.";
            TB2.BackColor = ConsoleColor.Blue;
            TB2.ForeColor = ConsoleColor.DarkGreen;

            TB2.DisplayText();


            Console.ReadKey();
        }
       
    }
}
