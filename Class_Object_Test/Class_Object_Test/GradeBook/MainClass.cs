using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Object_Test.GradeBook
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Book bobj = new Book("Prashant's Grade Book");
            bobj.add(4.5);
            bobj.add(5.5);
            bobj.add(1.4);
            bobj.add(6.3);

            var result=bobj.getStatistics();
            Console.WriteLine("Hightest grade of " + result.name + " : " + result.highGrade);
            Console.WriteLine("Minimun grade of " + result.name + " : " + result.minGrade);
            Console.WriteLine("Average grade of " + result.name + " : " + result.res);

        }
    }
}
