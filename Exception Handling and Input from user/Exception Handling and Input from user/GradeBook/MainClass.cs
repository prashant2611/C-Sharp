using System;
using System.Collections.Generic;
using System.Text;

namespace Exception_Handling_and_Input_from_user.GradeBook
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Book bobj = new Book("Prashant's Grade Book");
            string choice;

            // Taking input from user.
            do
            {
                try
                {
                    Console.WriteLine("Enter grade value: ");
                    bobj.add(double.Parse(Console.ReadLine()));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                   // throw;                           to exit() from program.
                }
                finally
                {
                    Console.WriteLine("Finally block.");
                }

                Console.WriteLine("Do you want to continue, then press yes.");
                choice = Console.ReadLine();
            } while (choice == "yes");
            
            /*bobj.add(4.5);
            bobj.add(5.5);
            bobj.add(1.4);
            bobj.add(6.3);
            */

            var result = bobj.getStatistics();
            Console.WriteLine("Hightest grade of " + result.name + " : " + result.highGrade);
            Console.WriteLine("Minimun grade of " + result.name + " : " + result.minGrade);
            Console.WriteLine("Average grade of " + result.name + " : " + result.res);

        }
    }
}