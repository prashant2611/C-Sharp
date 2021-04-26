using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace Class_Object_Test.GradeBook
{
    public class Statistics             //internal used for only project scope.
    {
        public String name;
        public double highGrade = double.MinValue;
        public double minGrade = double.MaxValue;
        public double sum = 0;
        public int count = 0;
    
     
        public void add(double number)
        {
            sum = sum + number;
            count++;

            highGrade = Math.Max(number, highGrade);
            minGrade = Math.Min(number,  minGrade);
        }

        public double average()
        {
                return sum / count;
        }

        public void writefile(double number)
        {
            using (var writer = File.AppendText($"name"))
            {
                writer.WriteLine(number);
            }    
        }

 
    }
}
