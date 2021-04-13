using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Object_Test.GradeBook
{
    class Book
    {
        private List<double> grade;
        String name;
        double highGrade = double.MinValue;
        double minGrade = double.MaxValue;
        double res = 0;

        public Book(String name)
        {
            grade = new List<double>();
            this.name = name;
        }

        public void add(double n)
        {
            grade.Add(n);
        }

        public void showStatistics()
        {
            foreach (double n in grade)
            {
                highGrade = Math.Max(n, highGrade);
                minGrade = Math.Min(n, minGrade);
                res = res + n;
            }
            res = res / grade.Count;

            Console.WriteLine("Hightest grade of " + name + " : " + highGrade);
            Console.WriteLine("Minimun grade of " + name + " : " + minGrade);
            Console.WriteLine("Average grade of " + name + " : " + res);
        }
    }
}
