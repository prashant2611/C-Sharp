using System;
using System.Collections.Generic;
using System.Text;

namespace Collection_Framework.Extract_data_from_CSV_file
{
 
    class MainClass
    {
        /*
        static void Main(string[] args)
        {
            /*string file_path = @"H:\KLINGELNBERG\Training Assignments\C#\Collection Framework\Collection Framework\Extract data from CSV file\Final.csv";
            FileReader reader = new FileReader(file_path);

            Country[] countries = reader.readFirstNCountries(7);

            foreach(Country country in countries)
            {
                Console.WriteLine($"{country.population} : {country.name}");
            }
            */


            /*string file_path = @"H:\KLINGELNBERG\Training Assignments\C#\Collection Framework\Collection Framework\Extract data from CSV file\Final.csv";
            FileReader_using_List reader = new FileReader_using_List(file_path);

            List<Country> countries = reader.readFirstAllCountries();

            foreach (Country country in countries)
            {
                Console.WriteLine($"{country.population} : {country.name}");
            }
            */

            /*Dictiionary dobj = new Dictiionary();
            dobj.add();
            dobj.show();
            dobj.check();
            

            string file_path = @"H:\KLINGELNBERG\Training Assignments\C#\Collection Framework\Collection Framework\Extract data from CSV file\Final.csv";
            FileReader_using_Dictionary reader = new FileReader_using_Dictionary(file_path);

            var countries = reader.readFirstAllCountries();

            foreach (Country country in countries.Values)
            {
                 Console.WriteLine($"{country.population} : {country.name}");
            }
        }
     */
    }
    
}
