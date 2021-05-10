using Events__Delegates_and_Lambdas.Action;
using Events__Delegates_and_Lambdas.Delegates;
using Events__Delegates_and_Lambdas.Events;
using Events__Delegates_and_Lambdas.Lambda;
using System;

namespace Events__Delegates_and_Lambdas
{
    public delegate int ArithmeticDelegate(int x, int y);

    class MainClass
    {
        static void Main(string[] args)
        {
            //Calculator cobj = new Calculator();

            /*Calculations CalDelegate;
            CalDelegate = cobj.sub;
            CalDelegate += cobj.add;

            CalDelegate.Invoke(5, 3);         
            */

            /*Calculations CalDelegate1 = new Calculations(cobj.add);
            Calculations CalDelegate2 = new Calculations(cobj.sub);
            CalDelegate1 += CalDelegate2;
            CalDelegate1(5, 4);
            */

            /*Calculations CalDelegate = new Calculations(cobj.add);
            //CalDelegate.Invoke(7, 8);
            CalDelegate(4, 5);
            */

            /*Calculations AddDelegate = new Calculations(cobj.add);
            cobj.AssignDelegate(AddDelegate);         //Dynamic (Using this, we can send method in function parameter.)
            */



            /*
            LambdaClass lobj = new LambdaClass();
            Console.WriteLine(lobj.add(5, 6));
            */

            /*LambdaClass lobj = new LambdaClass();
            ArithmeticDelegate add = (x, y) => x + y;
            ArithmeticDelegate mul = (x, y) => x * y;

            lobj.OperationDelegate(4, 5, mul);   //this make loose coupling.
            */

            /*ActionClass aobj = new ActionClass();
            aobj.display();
            */


            /*ActionClass aobj = new ActionClass();
            Action<int,int> Add = (x, y) => Console.WriteLine(x + y);
            Action<int, int> mul = (x, y) => Console.WriteLine(x * y);

            aobj.ArithmeticOperation(4, 5, mul);
            */


            Calculator cobj = new Calculator();
            EventClass eobj = new EventClass();
            // ArithmeticOperations arithmeticOperationsDelegate;
            eobj.WorkPerformed += cobj.add;
            eobj.WorkPerformed += cobj.sub;
            eobj.WorkPerformed += cobj.mul;
            eobj.WorkPerformed += cobj.add;
            eobj.WorkPerformed -= cobj.sub;
            eobj.WorkPerformed += delegate (int x, int y)           //Anonymous method.
                  {
                      Console.WriteLine("division of given values: " + (x / y));
  
                   };  


            eobj.DoWork(4,5);
            //eobj.Working(5, 6);    //another event


        }
    }
}
