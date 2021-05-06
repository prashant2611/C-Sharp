using System;
using System.Collections.Generic;
using System.Text;

namespace Interface.Explicit_Implementation
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Explicit_Implementation_Class eobj = new Explicit_Implementation_Class();
            eobj.save();

            IExplicit_Implementation iobj = new Explicit_Implementation_Class();
            iobj.save();
        }
    }
}
