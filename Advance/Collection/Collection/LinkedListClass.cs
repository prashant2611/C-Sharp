using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    class LinkedListClass
    {
        LinkedList<Student> LinkedlistStudent = new LinkedList<Student>();

        public void Add(Student s)
        {
            LinkedlistStudent.AddLast(s);
        }
        
        public void DisplayList()
        {
            foreach(var l in LinkedlistStudent)
            {
                Console.WriteLine(l.name);
            }
        }
    }
}
