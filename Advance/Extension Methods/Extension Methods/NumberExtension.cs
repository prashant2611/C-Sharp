using System;
using System.Collections.Generic;
using System.Text;

namespace Extension_Methods
{
    public static class NumberExtension
    {
        public static int Substraction(this Number number,int a,int b)    //Extends in own class
        {
            return a-b; 
        }

        public static int StringLengthPlusTen(this String stringint)   //extends in String class
        {
            return stringint.Length+10;
        }

        public static int IntLength(this Int32 x)   //Integer is a struct but we can add external methods in it.
        {
            return x * 10;
        }
    }
}
