using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented_Programming.GradeBook
{
    class BaseClass
    {
        public BaseClass()
        {
            Console.WriteLine("Constructor of Base Class.");
        }
        
        public void fun()
        {
            Console.WriteLine("Fun of Base.");
        }
    }

    class Base_and_This : BaseClass
    {
        public Base_and_This()
        {
            Console.WriteLine("Constructor of Derived Class.");
            this.fun();               
            base.fun();             //Acts as a super.
        }

        void fun()
        {
            Console.WriteLine("Fun of derived.");
        }
    }
}
