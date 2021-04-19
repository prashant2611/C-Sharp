using System;
using System.Collections.Generic;
using System.Text;

namespace Collection_Framework.Extract_data_from_CSV_file
{
    class Dictiionary
    {
        Country india = new Country("China", "CHN", "Asia", 1439323776);
        Country china = new Country("India", "IND", "Asia", 1380004385);

        Dictionary<string, Country> countries = new Dictionary<string, Country>();

        public void add()
        {
            countries.Add(india.code, india);
            countries.Add(china.code, china);
        }  

        public void show()
        {
            foreach(var country in countries.Values)
            {
                Console.WriteLine("Name of country: " + country.name);
            }
        }

        public void check()
        {
            bool exists = countries.TryGetValue("IND", out Country country);
            if(exists)
            {
                Console.WriteLine(country.name);
            }
            else
            {
                Console.WriteLine("Key does not exists in given dictionary.");
            }
        }
    }
}
