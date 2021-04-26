using Interface.Libraries;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interface.Shape.Libraries
{
    public class Square : Concreate_Class
    {
        public Square(double side):base(side)
        {}

        public override double Area()
        {
            return sidelength * sidelength;
        }
    }
}
