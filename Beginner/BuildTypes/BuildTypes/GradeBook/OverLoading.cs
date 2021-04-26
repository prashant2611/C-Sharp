using System;
using System.Collections.Generic;
using System.Text;

namespace BuildTypes.GradeBook
{
    class OverLoading
    {
        public int add(int a,int b)
        {
            return a + b;
        }

        public int add(int a,int b,int c)
        {
            return a + b + c;
        }
    }
}
