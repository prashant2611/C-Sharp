using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp
{
    class Program
    {
        const string InputFileName = "logo.png";
        const string EncodedFileName = "logo.txt";
        const string DecodedFileName = "logo_decoded.png";

        static void Main(string[] args)
        {
            ConvertFileToBase64();
            ConvertFileFromBase64();

            ConvertIntToBinary();

            ConvertDateTimeToBinary();

            ChangeTypeExample();
            ChangeTypeExampleV2();
            ChangeTypeExampleV3();

            ConvertCharacterToNumber();

            WriteLine("Press enter to exit.");
            ReadLine();
        }


        private static void ConvertFileToBase64()
        {

        }
        
        private static void ConvertFileFromBase64()
        {

        }
        
        private static void ConvertIntToBinary()
        {

        }

        private static void ConvertDateTimeToBinary()
        {

        }

        private static void ChangeTypeExample()
        {                        
      
        }

        private static void ChangeTypeExampleV2()
        {            

        }

        private static void ChangeTypeExampleV3()
        {

        }

        private static void ConvertCharacterToNumber()
        {

        }

    }
}
