using System;
using System.Collections.Generic;
using System.Text;

namespace Events__Delegates_and_Lambdas.Action
{
    class ActionClass
    {
        Action<string> show;

        public void display()
        {
            show = showString;
            show("Prashant Patil");

            show = Console.WriteLine;
            show("Hello");
        }

        void showString(string _rough)
        {
            Console.WriteLine(_rough);
        }

        public void ArithmeticOperation(int x,int y,Action<int,int> action)
        {
            action(x, y);
            Console.WriteLine("Operation Performed.");
        }
    }
}
