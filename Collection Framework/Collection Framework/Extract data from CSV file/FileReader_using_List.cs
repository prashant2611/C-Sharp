using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Collection_Framework.Extract_data_from_CSV_file
{
    class FileReader_using_List
    {
        string path;

        public FileReader_using_List(string path)
        {
            this.path = path;
        }

        public List<Country> readFirstAllCountries()
        {
            List<Country> countries = new List<Country>();

            using (StreamReader sr = new StreamReader(path))
            {
                sr.ReadLine();
                string csvline;

                while((csvline=sr.ReadLine())!=null)
                { 
                countries.Add(ReadCountryFromFile(csvline));           //Add
                }

                Country country = new Country("Navapur", "NVP", "Nandurbar", 1439323776);   //Insert
                countries.Insert(3, country);
                countries.RemoveAt(3);
            }

            return countries;
        }

        public Country ReadCountryFromFile(string FileLine)
        {
            string[] parts = FileLine.Split(',');

            string name = parts[0];
            string code = parts[1];
            string region = parts[2];
            int population = int.Parse(parts[3]);

            return new Country(name, code, region, population);
        }
    }
}
