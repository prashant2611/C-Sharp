using System;
using System.Collections.Generic;
using System.Text;

namespace Events__Delegates_and_Lambdas.Events
{
    
    class EventClass
    {
        public delegate void ArithmeticOperations(int x, int y);
        public event ArithmeticOperations WorkPerformed;

       // public event EventHandler<WorkPerfomedEventArgs> EventPerforming;
        
        public void DoWork(int x,int y)
        {
            OnWorkPerformed(x, y);
        }

        public void Working(int x,int y)
        {
            if(WorkPerformed!=null)
            {
                WorkPerformed(x, y);
            }
        }

        protected void OnWorkPerformed(int x,int y)
        {
            if (WorkPerformed != null)
            {
                WorkPerformed(x, y);
            }
        }
    }
}
