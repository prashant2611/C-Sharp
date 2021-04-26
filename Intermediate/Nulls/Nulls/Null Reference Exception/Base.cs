using System;
using System.Collections.Generic;
using System.Text;

namespace Nulls.Null_Reference_Exception
{
    class Base
    {
        IShape iobj = null;
        public Base(IShape iobj)
        {
            this.iobj = iobj;
        }

        public void display()
        {
            if(iobj!=null)
            {
                iobj.draw();
            }
        }
    }
}
