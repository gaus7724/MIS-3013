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

            
            Console.ReadKey();
        }
       
    }
}
