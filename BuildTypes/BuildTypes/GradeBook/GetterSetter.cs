using System;
using System.Collections.Generic;
using System.Text;

namespace BuildTypes.GradeBook
{
    class GetterSetter
    {
        private string name="Prashant";
        readonly string surname = "Patil";    // we can write only Getter for this variable, but we can write Setter . (We can only change this variable value in constructor.)
        public const int X = 10;          // we cannot change it anywhere and Const variable is bydefalt static in nature. (Write const variable name in upper case, it is company standard.)

        public string getName()
        {
            return name;
        }

        public void setName(String s)
        {
            name = s;
        }

    }
}
