using System;
using System.Collections.Generic;
using System.Text;

namespace Reference_Types_and_Value_Types.GradeBook
{
    public class Book
    {
        private List<double> grade;
        public String name2;
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
            name2 = name;
        }

        public void add(double n)
        {
            grade.Add(n);
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