using System;
using System.Collections.Generic;
using System.Text;

namespace Interface.Explicit_Implementation
{
    class Explicit_Implementation_Class:IExplicit_Implementation
    {
       public void save()
        {
            Console.WriteLine("Class save method.");
        }

        void IExplicit_Implementation.save()
        {
            Console.WriteLine("Interface save method.");
        }
    }
}
