using System;
using System.Collections.Generic;
using System.Text;

namespace Nulls.Null_Reference_Exception
{
    class NullDefence:IShape
    {
        public void draw()
        {
            Console.WriteLine("Null value.");
        }
    }
}
