using System;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Greet();

            DisplaySystemInfo();

            ChangeCulture();

            RunReport();

            RunExternal();


            WriteLine("Press enter to exit");
            ReadLine();
        }

        private static void Greet()
        {

        }

        private static void DisplaySystemInfo()
        {

        }


        private static void ChangeCulture()
        {

        }

        private static void RunReport()
        {

        }

        private static async Task<string> LoadFile(string fileName)
        {
            return "";
        }

        private static void RunExternal()
        {
        
        }
    }
}

