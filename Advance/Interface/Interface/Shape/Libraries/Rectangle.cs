using Interface.Libraries;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interface.Shape.Libraries
{
    class Rectangle:Interface_Class
    {
        public double side1 { get; set;}
        public double side2 { get; set;}
        public Rectangle(double sidei,double sideii)
        {
            side1 = sidei;
            side2 = sideii;
        }
        public double Area()
        {
            return side1 * side2;
        }
    }
}
