using System;
using System.Collections.Generic;
using System.Text;

namespace Nulls.Null_Reference_Exception
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Base bobj = new Base(new Triangle());
            Base b2obj = new Base(new Circle());
            Base b3obj = new Base(new NullDefence());

            bobj.display();
            b2obj.display();
            b3obj.display();
        }
    }
}
