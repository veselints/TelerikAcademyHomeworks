using System;
using System.Text.RegularExpressions;

namespace P25ExtractTextFromHTML
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the HTML: ");
            string sample = Console.ReadLine(); 
            string title = GetTitle(sample);
            if (String.IsNullOrWhiteSpace(title))
                title = "(none)";
            string body = GetText(sample);
            Console.WriteLine(@"
Title:  {0}
Text:   {1}
", title, body);
        }

        private static string GetText(string sample)
        {
            string text = Regex.Match(sample, @"<\s*body\s*>.*?<\s*/\s*body\s*>").ToString();
            text = Regex.Replace(text, @"<.*?>", String.Empty);
            return text.Trim();
        }

        private static string GetTitle(string sample)
        {
            string head = Regex.Match(sample, @"<\s*head\s*>.*?<\s*/\s*head\s*>").ToString();
            if (head == String.Empty || !head.Contains("title"))
            {
                return string.Empty;
            }

            string title = Regex.Match(head, @"<\s*title\s*>.*?<\s*/\s*title\s*>").ToString();
            title = Regex.Replace(title, @"<\s*title\s*>", String.Empty);
            title = Regex.Replace(title, @"<\s*/\s*title\s*>", String.Empty);

            return title.Trim();
        }
    }
}
