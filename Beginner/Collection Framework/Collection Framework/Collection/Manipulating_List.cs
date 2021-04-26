using System;
using System.Collections.Generic;
using System.Text;

namespace Collection_Framework.Collection
{
    class Manipulating_List
    {
        List<int> list = new List<int>()
        {
            1,2,3,4,5,6,7,8,9,10
        };

        public void foreachLoop()
        {
            foreach(int x in list)          //used for only read purpose
            {
                Console.WriteLine(x);
            }
        }

        public void forLoop()
        {
            for(int i=0;i<list.Count;i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
