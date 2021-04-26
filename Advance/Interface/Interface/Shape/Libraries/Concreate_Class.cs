using System;
using System.Collections.Generic;
using System.Text;

namespace Interface.Libraries
{
    public class Concreate_Class
    {
        public double sidelength { get; set; }

        public Concreate_Class(double side)
        {
            sidelength = side;
        }
        public virtual double Area()
        {
            throw new NotImplementedException();
        }
    }
}
