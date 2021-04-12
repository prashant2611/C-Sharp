using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp.GradeBook
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Book bobj = new Book("Prashant's Grade Book");
            bobj.add(4.5);
            bobj.add(5.5);
            bobj.add(1.4);
            bobj.add(6.3);

            bobj.showStatistics();
            
        }
    }
}
