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
        double sum;
        public double CalculateGPA()
        {
            
            double numGrade;
            foreach (var grade in CourseGrades)
            {
                if (grade == "A")
                {
                    numGrade = 4;
                }
                if (grade == "B")
                {
                    numGrade = 3;
                }
                if (grade == "C")
                {
                    numGrade = 2;
                }
                if (grade == "D")
                {
                    numGrade = 1;
                }
                else
                {
                    numGrade = 0;
                }
                 
                sum = sum + numGrade;
            }
            
            double GPA = sum / CourseGrades.Count;
            Console.WriteLine($"Your GPA for {CourseNames} is {GPA}.");
            return GPA;
            

        }
        



    }
}
