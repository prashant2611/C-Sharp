using Interface.Libraries;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interface.Shape.Libraries
{
    class Circle:Abstract_Class
    {
        public Circle(double red):base(red)
        { }

        public override double Area()
        {
            return 3.14 * redious * redious;
        }
    }
}
