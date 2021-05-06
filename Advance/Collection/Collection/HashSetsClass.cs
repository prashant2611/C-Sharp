using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    class HashSetsClass
    {
        HashSet<int> _hashSet = new HashSet<int>();
        //SortedSet<int> _hashSet = new SortedSet<int>();     //Sorted
        HashSet<int> _hashSet2 = new HashSet<int>()
        {
            3,4,5,6
        };



        public void PushInHash(int number)
        {
            _hashSet.Add(number);
        }

        public void DisplayHash()
        {
          foreach(int n in _hashSet)
            {
                Console.WriteLine(n);
            }
        }
        public void Union()
        {
             _hashSet.UnionWith(_hashSet2);
            foreach (int n in _hashSet)
            {
                Console.WriteLine(n);
            }
        }

        public void Intersection()
        {
            _hashSet.IntersectWith(_hashSet2);
            foreach (int n in _hashSet)
            {
                Console.WriteLine(n);
            }
        }
    }
}
