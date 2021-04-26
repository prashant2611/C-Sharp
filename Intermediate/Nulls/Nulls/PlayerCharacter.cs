using System;
using System.Collections.Generic;
using System.Text;

namespace Nulls
{
    class PlayerCharacter
    {
        /*public string name { get; set;}                  // String is reference type so we dont need to use nullable type
        public int days_since_lastLogin { get; set; }    // we cannot assign null value to value types i.e int,etc. so we need to use magic number insted of null and it will create a problem.  Thus we use nullable type hence we can assign null value to type values.
        public DateTime dob { get; set; }
        */

        public string name { get; set; }                  // String is reference type so we dont need to use nullable type
        //public Nullable<int> days_since_lastLogin { get; set; }    // we cannot assign null value to value types i.e int,etc. so we need to use magic number insted of null and it will create a problem.  Thus we use nullable type hence we can assign null value to type values.
        //or
        public int? days_since_lastLogin { get; set; }         //another way
        public Nullable<DateTime> dob { get; set; }               //now we can assign null value to value types.

        public bool? isNew { get; set; }

    }
}
