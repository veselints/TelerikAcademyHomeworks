// Write a program that extracts from given XML file all the text without the tags.

using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;


class P10ExtractTextFromXML
{
    static void Main()
    {
        using (StreamReader streamReader = new StreamReader("../../XML.xml"))
        {
            for (int index; (index = streamReader.Read()) != -1; )
            {
                if (index == '>')
                {
                    StringBuilder text = new StringBuilder();

                    while (((index = streamReader.Read()) != '<') && index != -1)
                    {
                        text.Append((char)index);
                    }

                    string newText = Convert.ToString(text).Trim();

                    if (!String.IsNullOrWhiteSpace(newText))
                    {
                        Console.WriteLine(newText);
                    }
                }
            }
        }

        string textXML = File.ReadAllText("../../XML.xml");
        string pattern = @"(?s)>\s*(.*?)\s*<";
        var str = Regex.Matches(textXML, pattern);

        for (int index = 0; index < str.Count; index++)
        {
            var result = str[index].Groups[1].Value;

            if (!string.IsNullOrWhiteSpace(result))
            {
                Console.WriteLine(result);
            }
        }
    }
}
