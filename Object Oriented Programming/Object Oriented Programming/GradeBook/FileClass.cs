using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Object_Oriented_Programming.GradeBook
{
    class FileClass
    {
        public void add(String name)
        {
            var Writer=File.AppendText($"Name.txt");
            Writer.WriteLine(name);
            Writer.Dispose();              //It use for close the file and free that memory.
        }
    }
}
