using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collection
{
    class IEnumarable_And_IEnumarator
    {
        List<int> years = new List<int>()
        {
            1990,
            1993,
            1996,
            1998,
            2001,
            2002,
            2003
        };

        public void iCollection()   //We can perform Add,Update,Remove,Count  in ICollection but not insert and remove at element at anyposition.
        {
            ICollection<int> icollection = years;
            icollection.Add(2005);
            Console.WriteLine($"Count of years: {icollection.Count()}");
            icollection.Remove(2001);
            Console.WriteLine(icollection.Contains(2003));
            Console.WriteLine($"Count of years: {icollection.Count()}");
        }

        public void iList()   //In IList, we can insert and remove element 
        {
            IList<int> ilist = years;
            Console.WriteLine($"Count of years: {ilist.Count()}");
            ilist.Insert(2, 1992);
            Console.WriteLine($"Count of years: {ilist.Count()}");
            ilist.RemoveAt(1);
            Console.WriteLine($"Count of years: {ilist.Count()}");
        }

        public void iEnumerable()  //We cannot add,update,remove,count in IEnumerable.
        {
            IEnumerable<int> ienum = (IEnumerable<int>)years;
            iEnumerableBelow2000(ienum);
            /*foreach(int i in ienum)
            {
                Console.WriteLine(i);
            }*/
            
        }

        public void iEnumerator()
        {
            IEnumerator<int> ienumerator = years.GetEnumerator();
            iEnumeratorBelow2000(ienumerator);

            /*while(ienumerator.MoveNext())
            {
                Console.WriteLine(ienumerator.Current);
            }*/
            
        }


       public void iEnumeratorBelow2000(IEnumerator<int> ienumerator_years)
        {
            while(ienumerator_years.MoveNext())
            {
                Console.WriteLine(ienumerator_years.Current);
                if(ienumerator_years.Current>2000)
                {
                    iEnumaratorAbove2000(ienumerator_years);
                }
            }
        }

        public void iEnumaratorAbove2000(IEnumerator<int> ienumerator_years)
        {
            while (ienumerator_years.MoveNext())
            {
                Console.WriteLine(ienumerator_years.Current);
            }
        }



        public void iEnumerableBelow2000(IEnumerable<int> ienumerable_years)
        {
            foreach (int current in ienumerable_years)
            {
                Console.WriteLine(current);
                if (current > 2000)
                {
                    iEnumarableAbove2000(ienumerable_years);
                }
            }
        }

        public void iEnumarableAbove2000(IEnumerable<int> ienumerable_years)
        {
         foreach(int current in ienumerable_years)
            {
                Console.WriteLine(current);
            }
        }
       
    }
}
