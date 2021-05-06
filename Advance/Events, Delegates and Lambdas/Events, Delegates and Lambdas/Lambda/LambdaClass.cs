using System;
using System.Collections.Generic;
using System.Text;

namespace Events__Delegates_and_Lambdas.Lambda
{
    public delegate int Add(int x, int y);
    class LambdaClass
    {
        public Add add = (x, y) => x + y;

        public void OperationDelegate(int x,int y, ArithmeticDelegate del)
        {
            int answer = del(x, y);
            Console.WriteLine(answer);
        }
    }
}
