// Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P15ReplaceTags
{
    class Program
    {
        static void Main(string[] args)
        {
            string html = Console.ReadLine();
            string replaced = html.Replace(@"<a href=""", "[URL=");
            replaced = replaced.Replace(@""">", "]");
            replaced = replaced.Replace("</a>", "/URL]");

            Console.WriteLine(replaced);
        }
    }
}