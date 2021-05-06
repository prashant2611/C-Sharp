using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collection
{
    class Display
    {
        List<Student> students = new List<Student>()
          {
              new Student("Prashant",105),
              new Student("Nilesh",104),
              new Student("Gauri",103),
              new Student("Vijay",102),
              new Student("Pawan",101)
          };



        public Dictionary<int, Student> dictStudents;
        SortedDictionary<int, Student> sortdictStudent;
       

        public void DisplayList()
        {

            foreach (Student s in students)
            {
                Console.WriteLine("Name: " + s.name + ", ID: " + s.ID);
            }
        }

        public void ConvertListToDict()
        {
            dictStudents= students.ToDictionary(x => x.ID);
            sortdictStudent = new SortedDictionary<int, Student>(dictStudents);
        }

        public void DisplayDict()
        {
            foreach(var d in dictStudents)
            {
                Console.WriteLine(d.Key +" Name: "+d.Value.name);
            }
        }

        public void DisplaySortedDict()
        {
            foreach (var d in sortdictStudent)
            {
                Console.WriteLine(d.Key + " Name: " + d.Value.name);
            }
        }
    }
}
