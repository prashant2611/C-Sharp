using System;
using System.Collections.Generic;
using System.Text;

namespace Exception_Handling_and_Input_from_user.GradeBook
{
    class Book
    {

        private List<double> grade;
        /*String name;
        double highGrade = double.MinValue;
        double minGrade = double.MaxValue;
        double res = 0;
        */
        Statistics result = new Statistics();

        public Book(String name)
        {
            grade = new List<double>();
            result.name = name;
        }

        public void add(double n)
        {
            if(n>=0 && n<=100)
            {
                grade.Add(n);
            }
           else
            {
                throw new ArgumentException($"Invalid input");
            }
        }

        public Statistics getStatistics()
        {
            foreach (double n in grade)
            {
                result.highGrade = Math.Max(n, result.highGrade);
                result.minGrade = Math.Min(n, result.minGrade);
                result.res = result.res + n;
            }
            result.res = result.res / grade.Count;

            return result;

        }
    }
}