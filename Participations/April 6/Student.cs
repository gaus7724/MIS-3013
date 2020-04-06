using System;
using System.Collections.Generic;
using System.Text;

namespace April_6
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<string> CourseNames { get; set; }
        public List<string> CourseGrades { get; set; }

        public Student()
        {
            FirstName = "";
            LastName = "";
        }
        public double CalculateGPA()
        {
           
            double sum = 0;
            foreach (var grade in CourseGrades)
            {
                sum = sum + Convert.ToDouble(grade);
            }
            Convert.ToDouble(CourseGrades);
            double average = sum / CourseGrades.Count;
            Console.WriteLine($"The average of your course grades is {average}");

        }
        



    }
}
