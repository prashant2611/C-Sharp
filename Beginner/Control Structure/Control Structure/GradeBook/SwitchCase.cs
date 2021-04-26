using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Structure.GradeBook
{
    class SwitchCase
    {
        char letter = 'B';

        public void switch_case()
        {
            switch (letter)
            {
                case 'A':
                    Console.WriteLine("A grade.");
                    break;
                case 'B':
                    Console.WriteLine("B grade.");
                    break;
                case 'C':
                    Console.WriteLine("C grade.");
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}
