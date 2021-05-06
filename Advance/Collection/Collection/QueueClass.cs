using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    class QueueClass
    {
        Queue<int> numbers = new Queue<int>();

        public void PushInQueue(int number)
        {
            numbers.Enqueue(number);
        }

        public int PopInQueue()
        {
            if (numbers.Count != 0)
            {
                return numbers.Dequeue();
                //return numbers.Peek();
            }
            else
            {
                return -1;
            }
        }
    }
}
