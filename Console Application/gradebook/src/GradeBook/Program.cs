using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
          /*if(args.Length>0)                   // To prevent from ArrayIndexOutOfBounce Exception.
            { 
            Console.WriteLine("Hello "+args[0]+"!");
            Console.WriteLine($"Hello {args[0]}!");
            }
            else
            {
            Console.WriteLine("Hello World!");
            }*/

            /*var x=3.4;      // var keyword is tells the compiler to figure out the type of the variable at compilation time.
            var y=4.8;
            var result=x+y;
            Console.WriteLine(result);
            */

            /*double[] arr=new double[3] {3.2,4.5,6.2};
            //var arr=new[]{3.2,4.5,6.2};              another way
            double addition=arr[0]+arr[1]+arr[2];
            Console.WriteLine(addition);
            */

            /*double[] arr=new double[] {3.4,5.6,2.3,6.3};
            double result=0;
            foreach(double n in arr)
            {
                result=result+n;
            }
            Console.WriteLine(result);
            */

            List<double> grade=new List<double>() {4.2,6.1,8.8};
            double result=0;
            grade.Add(3.2);
            grade.Add(4.5);
            foreach(double n in grade)
            {
                result+=n;
            }
            result=result/grade.Count;
            Console.WriteLine($"Hello {args[0]} your average grade is {result:N2}.");   //N2 is used for to take only two digits after the decimal point.
        }
    }
}
