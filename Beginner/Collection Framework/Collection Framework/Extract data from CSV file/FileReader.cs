using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Collection_Framework.Extract_data_from_CSV_file
{
    class FileReader
    {
        string path;

        public FileReader(string path)
        {
            this.path = path;
        }

        public Country[] readFirstNCountries(int total_countries)
        {
            Country[] countries = new Country[total_countries];

            using(StreamReader sr=new StreamReader(path))
            {
                sr.ReadLine();
                for(int i=0;i<total_countries;i++)
                {
                    string csvline = sr.ReadLine();
                    countries[i] = ReadCountryFromFile(csvline);
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
