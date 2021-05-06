using System;
using System.Collections.Generic;
using System.Linq;

namespace Collection
{
    class MainClass
    {
        static void Main(string[] args)
        {
            /*Display dobj = new Display();
            dobj.DisplayList();
            dobj.ConvertListToDict();
            //Console.WriteLine(dobj.dictStudents[101].name);
            dobj.DisplayDict();
            dobj.DisplaySortedDict();
            */

            /*LinkedListClass lobj = new LinkedListClass();
            lobj.Add(new Student("Prashant", 1));
            lobj.Add(new Student("Gauri", 3));
            lobj.Add(new Student("Nilesh", 5));

            lobj.DisplayList();
            */

            /*StackClass sobj = new StackClass();
            sobj.PushInStack(1);
            sobj.PushInStack(2);
            sobj.PushInStack(3);
            sobj.PushInStack(4);

            Console.WriteLine(sobj.PopInStack());
            Console.WriteLine(sobj.PopInStack());
            Console.WriteLine(sobj.PopInStack());
            Console.WriteLine(sobj.PopInStack());
            Console.WriteLine(sobj.PopInStack());
            */

            /*QueueClass qobj = new QueueClass();
            qobj.PushInQueue(1);
            qobj.PushInQueue(2);
            qobj.PushInQueue(3);
            qobj.PushInQueue(4);
            qobj.PushInQueue(5);

            Console.WriteLine(qobj.PopInQueue());
            Console.WriteLine(qobj.PopInQueue());
            Console.WriteLine(qobj.PopInQueue());
            Console.WriteLine(qobj.PopInQueue());
            Console.WriteLine(qobj.PopInQueue());
            Console.WriteLine(qobj.PopInQueue());
            */

            HashSetsClass hobj = new HashSetsClass();
        
            hobj.PushInHash(3);
            hobj.PushInHash(3);
            hobj.PushInHash(1);
            hobj.PushInHash(1);
            hobj.PushInHash(2);
            hobj.PushInHash(2);

            hobj.DisplayHash();
            Console.WriteLine("...");
            hobj.Union();
            Console.WriteLine("...");
            hobj.Intersection();
        }
    }
}
