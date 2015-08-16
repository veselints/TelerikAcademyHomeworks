using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_17_Longest_string
{
    public static class StringArrayExtention
    {
        public static string LongestString(this String[] stringArray)
        {
            var orderedArray = 
                from str in stringArray
                orderby (str.Length) descending
                select str;

            return orderedArray.FirstOrDefault(); ;
        }
    }
}
