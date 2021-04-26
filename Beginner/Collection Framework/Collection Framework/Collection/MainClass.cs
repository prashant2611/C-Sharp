using System;
using System.Collections.Generic;
using System.Text;

namespace Collection_Framework.Collection
{
    class MainClass
    {
        
         static void Main(string[] args)
        {
            /*ArrayClass aobj = new ArrayClass();
            foreach (string s in aobj.daysofWeek)
            {
                Console.WriteLine(s);
            }
            */

            /*ListClass lobj = new ListClass();
            foreach(string s in lobj.list)
            {
                Console.WriteLine(s);
            }
            */

            /*Manipulating_List lobj = new Manipulating_List();
            lobj.foreachLoop();
            lobj.forLoop();
            */

            LINO_Class lobj = new LINO_Class();
            lobj.foreachLoop();
            lobj.orderby();
         

        }
    
    }
}
