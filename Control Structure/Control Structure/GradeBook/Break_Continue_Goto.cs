using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Structure.GradeBook
{
    class Break_Continue_Goto
    {

        public void forLoop()
        {
            for (int index = 0; index < 5; index++)
            {
                if (index == 4)
                {
                    goto done;
                }
                if (index == 3)
                {
                    continue;    // if we use break insted of continue then we terminate out of loop.
                }
                Console.WriteLine(index);
            }
        done:
            Console.WriteLine("Goto statement.");
        }
    }

}