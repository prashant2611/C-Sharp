using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Class_Object_Test.GradeBook
{
    public class Book
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
            grade.Add(n);
        }

        public Statistics getStatistics()
        {
            foreach (double n in grade)
            {
                result.add(n);
                result.writefile(n);
            }
            return result;
        }

        public Statistics FileAverage()
        {
            var resultnew = new Statistics();
            using (var readFile = File.OpenText($"name"))
            {
                var line = readFile.ReadLine();
                while (line != null)
                {
                    var number = double.Parse(line);
                    resultnew.add(number);
                    line = readFile.ReadLine();
                }
            }
            return resultnew; 
        }

    }
}
