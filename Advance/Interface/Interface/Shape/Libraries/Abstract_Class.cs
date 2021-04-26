using System;
using System.Collections.Generic;
using System.Text;

namespace Interface.Libraries
{
    abstract class Abstract_Class
    {
        public double redious { get; }

    
        public Abstract_Class(double red)
        {
            redious = red;
        }

        abstract public double Area();
    }
}
