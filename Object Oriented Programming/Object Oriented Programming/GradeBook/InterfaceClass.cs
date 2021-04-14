using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented_Programming.GradeBook
{

    interface IBase                            //If we declare any Interface then it is compulsory to keep I as starting variable.
    {
         public const int x = 4;                // we cannot declare variable without const.

        public void fun();
    }

    class InterfaceClass : IBase
    {
        public void fun()
        {
            Console.WriteLine("Fun of Interface.");
        }
    }
}
