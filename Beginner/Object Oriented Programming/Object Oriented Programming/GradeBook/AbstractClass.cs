using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented_Programming.GradeBook
{
    abstract class AbstractClass
    {
        public int x = 10;
        abstract public void fun();
        public void gun()
        {
            Console.WriteLine("Gun of Abstract class.");
        }
    }

    class Derived : AbstractClass
    {
        override public void fun()                     // When we override method then we need to use override keyword for that.
        {
            Console.WriteLine("Fun of Derived.");
        }
    }
}
