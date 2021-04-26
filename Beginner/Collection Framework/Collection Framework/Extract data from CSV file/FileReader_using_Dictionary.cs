using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Collection_Framework.Extract_data_from_CSV_file
{
    class FileReader_using_Dictionary
    {
        string path;

        public FileReader_using_Dictionary(string path)
        {
            this.path = path;
        }

        public Dictionary<string,Country> readFirstAllCountries()
        {
            Dictionary<string,Country> countries = new Dictionary<string,Country>();

            using (StreamReader sr = new StreamReader(path))
            {
                sr.ReadLine();
                string csvline;
                
                while((csvline=sr.ReadLine())!=null)
                { 
                   
                    Country country = ReadCountryFromFile(csvline);
                    countries.Add(country.code, country);
                }
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
