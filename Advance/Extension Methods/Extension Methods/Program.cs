using System;

namespace Extension_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Number nobj = new Number();
            Console.WriteLine(nobj.add(4, 5));
            Console.WriteLine(nobj.Substraction(5, 4));
            string name = "Prashant";
            Console.WriteLine(name.Length);
            Console.WriteLine(name.StringLengthPlusTen());
            int a = 10;
            Console.WriteLine(a.IntLength());
        }
    }
}
