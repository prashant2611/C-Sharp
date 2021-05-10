using System;
using System.Collections.Generic;
using System.Text;

namespace Events__Delegates_and_Lambdas.Delegates
{
    public delegate void Calculations(int x, int y);

    class Calculator
    {
        

        public void add(int a,int b)
        {
            Console.WriteLine("Addition of given number: " + (a + b));
        }

        public void sub(int a, int b)
        {
            Console.WriteLine("Sub of given number: " + (a - b));
        }
        public void mul(int a,int b)
        {
            Console.WriteLine("Multiplication of given number: " + (a * b));
        }

        public void AssignDelegate(Calculations del)
        {
            del(5, 6);
        }
    }
}
