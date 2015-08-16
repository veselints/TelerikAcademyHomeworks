using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_17_Longest_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringsArray = 
            {
                "qwefsdfsrty",
                "asdsfsdfd",
                "longefsdststring",
                "s fd sdfsdfsdf   sdhort",
                "bla",
                "ffoasfssgfaslhkkasksfjglafgfasklkasgflaksgfaslkflgaskfa"
            };

            Console.WriteLine(stringsArray.LongestString());
        }
    }
}
