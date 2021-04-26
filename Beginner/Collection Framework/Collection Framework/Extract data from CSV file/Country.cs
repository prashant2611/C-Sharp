using System;
using System.Collections.Generic;
using System.Text;

namespace Collection_Framework.Extract_data_from_CSV_file
{
    class Country
    {
        public string name { get; }
        public string code { get; }
        public string region { get; }
        public int population { get; }

        public Country(string name,string code,string region,int population)
            {
            this.name = name;
            this.code = code;
            this.region = region;
            this.population = population;
            }

    }
}
