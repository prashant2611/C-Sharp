using System.Collections.Generic;

namespace ClassLibrary.Tuples
{
    public class StringProcessor
    {
        private class Result
        {
            public int Length { get; set; }
            public string UppercaseVersion { get; set; }
        }

        public List<string> ToUpperAndWithLength(List<string> stringsToProcess)
        {
            var results = new List<string>();

            foreach (var s in stringsToProcess)
            {
                var result = Process(s);

                results.Add($"{result.Length}-{result.UppercaseVersion}");
            }

            return results;
        }        

        private Result Process(string s)
        {
            return new Result
            {
                Length = s.Length,
                UppercaseVersion = s.ToUpperInvariant()
            };           
        }
    }
}
