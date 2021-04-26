using System;
using System.Collections.Generic;
using System.Text;

namespace BuildTypes.GradeBook
{
    class MainClass
    {
        static void Main(string[] args)
        {
            /*
             Book bobj = new Book("Prashant's Grade Book");
            bobj.add(4.5);
            bobj.add(5.5);
            bobj.add(1.4);
            bobj.add(6.3);

            var result = bobj.getStatistics();
            Console.WriteLine("Hightest grade of " + result.name + " : " + result.highGrade);
            Console.WriteLine("Minimun grade of " + result.name + " : " + result.minGrade);
            Console.WriteLine("Average grade of " + result.name + " : " + result.res);
            */

            /*
            //Function Overloading    i.e. Type of Polymorphysm.
            OverLoading obj = new OverLoading();
            Console.WriteLine("Addition of two number: "+obj.add(3,4));
            Console.WriteLine("Addition of three number: "+obj.add(3, 4, 5));
            */

            //Getter Setter and Const 
            GetterSetter gobj = new GetterSetter();
            Console.WriteLine(gobj.getName());
            gobj.setName("Nilesh");
            Console.WriteLine(gobj.getName());
            Console.WriteLine(GetterSetter.X);   // we cannot access it using object because of static nature.

        }
    }
}
