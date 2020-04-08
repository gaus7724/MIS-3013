using System;
using System.Collections.Generic;
using System.Text;

namespace April_8
{
    class Toy
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        private string Aisle { get; set; }
        public Toy()
        {
            Manufacturer = "";
            Name = "";
            Price = 0;
            Aisle = "";
        }

        
        public string GetAisle()
        {
            char mLetter = Manufacturer[0];
            Random rnd = new Random();
            int rand = rnd.Next(1, 24);
            Console.WriteLine($"{mLetter} {rand}");

          string mLetterToString =  mLetter.ToString();
            return mLetterToString;
            
        }
    }
}
