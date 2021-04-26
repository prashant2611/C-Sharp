using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collection_Framework.Collection
{
    class LINO_Class
    {
        List<int> list = new List<int>()
        {
            1,2,3,4,5,6,7,8,9,10
        };

        public void foreachLoop()
        {
            foreach (int x in list.Take(4))          //used for only read purpose
            {
                Console.WriteLine(x);
            }
        }

        public void orderby()
        {
            foreach (int x in list.OrderByDescending(x=>x).Take(4))          //we have to use lamda expression here to access element
            {
                Console.WriteLine(x);
            }
        }
    }
}
