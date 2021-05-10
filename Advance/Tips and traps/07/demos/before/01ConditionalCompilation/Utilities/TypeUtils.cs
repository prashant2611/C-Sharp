using System;

namespace Utilities
{
    public static class TypeUtils
    {
        public static string GetNamespace(object o)
        {
            string result = "";

            result += "TODO: add namespace of object to result string";

            AppendDate(ref result);

            return result;
        }

        private static void AppendDate(ref string result)
        {
            result += " " + DateTime.Now.ToShortDateString();
        }
    }
} 
