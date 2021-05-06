using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    class StackClass
    {
        Stack<int> numbers = new Stack<int>();

        public void PushInStack(int number)
        {
            numbers.Push(number);
        }

        public int PopInStack()
        {
            if (numbers.Count != 0)
            {
                return numbers.Pop();
            }
            else
            {
                return -1;
            }
        }
    }
}
