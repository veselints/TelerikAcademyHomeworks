using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5ParseTags
{
    class Program
    {
        static void Main()
        {
            Console.Write("Tell us the text we are looking in: ");
            string text = Console.ReadLine();

            int indexOfTag = text.IndexOf("<u");
            int closingIndexOfTag = text.IndexOf("</");
            StringBuilder output = new StringBuilder(text);

            while (indexOfTag >= 0)
            {
                string subString = text.Substring(indexOfTag + 8, closingIndexOfTag - indexOfTag - 8);
                string subStringUpper = subString.ToUpper();
                output.Replace(subString, subStringUpper);
                indexOfTag = text.IndexOf("<u", indexOfTag + 1);
                closingIndexOfTag = text.IndexOf("</", closingIndexOfTag + 1);
            }

            output.Replace("<upcase>", "");
            output.Replace("</upcase>", "");

            string finalOutput = output.ToString();

            Console.WriteLine(finalOutput);
        }
    }
}
