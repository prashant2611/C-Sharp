using System;
using System.Collections.Generic;
using System.Text;

namespace Error_Handling_with_Exceptions
{
    class ThrowException
    {
        public void divide()
        {

            int b = 6;
            int a = 0;
            if (a == 0)
            {
                throw new ArithmeticException();
            }
            else
            {
                b = b / a;
            }
            Console.WriteLine(b);
        
        }
    }
}
