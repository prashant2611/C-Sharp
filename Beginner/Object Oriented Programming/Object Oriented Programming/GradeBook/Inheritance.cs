using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented_Programming.GradeBook
{
    class Inheritance : Base   // in C# there is not multiple inheritance.
    {
        public int x = 10;

        public void fun()
        {
            Console.WriteLine("Fun of Derived.");
        }
    }

    class Base 
    {
        public int y = 20;

        public void gun()
        {
            Console.WriteLine("gun of Base.");
        }
    }
}
