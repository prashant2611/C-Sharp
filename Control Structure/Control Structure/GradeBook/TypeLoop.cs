using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Structure.GradeBook
{
    class TypeLoop
    {
        int index = 0;

        public void doWhileLoop()
        {
            do
            {
                Console.WriteLine("Do while Loop.");
                index++;
            } while (index < 5);
        }

     
        public void whileLoop()
        {
            index = 0;
            while (index < 5)
            {
                Console.WriteLine("While Loop.");
                index++;
            }
        }

        internal void foreachLoop()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
            foreach(int l in list)
            {
                Console.WriteLine("For each Loop.");
            }
        }

        public void forLoop()
        {
            for(int index=0;index<5;index++)
            {
                Console.WriteLine("For Loop.");
            }
        }
    }
}
