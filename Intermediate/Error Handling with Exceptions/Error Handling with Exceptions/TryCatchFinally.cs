using System;
using System.Collections.Generic;
using System.Text;

namespace Error_Handling_with_Exceptions
{
    class TryCatchFinally
    {
        public void divide()
        {

            int b = 6;
            try
            {
                b = b / 0;
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Invalid expression.");
            }
        }
    }
}
