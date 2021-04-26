using System;

namespace Error_Handling_with_Exceptions
{
    class MainClass
    {
        static void Main(string[] args)
        {
            //TryCatch tobj = new TryCatch();
            //tobj.divide();

            /*TryCatchFinally fobj = new TryCatchFinally();
            fobj.divide();
            */

           try
            {
                ThrowException tobj = new ThrowException();
                tobj.divide();
            }
            catch
            {
                Console.WriteLine("Invalid expression.");
            }

  

        }
    }
}
