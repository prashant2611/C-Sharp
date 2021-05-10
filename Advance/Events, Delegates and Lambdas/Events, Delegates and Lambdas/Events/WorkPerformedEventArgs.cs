using System;
using System.Collections.Generic;
using System.Text;

namespace Events__Delegates_and_Lambdas.Events
{
    class WorkPerformedEventArgs:EventArgs
    {
        public WorkPerformedEventArgs(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
        public int x;
        public int y;
    }
}
