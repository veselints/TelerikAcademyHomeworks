namespace XML_Processing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml;
    using System.Xml.Linq;

    class SongTitlesExtractor
    {
        public static void WithXmlReader(string fileLocation)
        {
            Console.WriteLine("All song titles in the document: \n");
            using (XmlReader reader = new XmlTextReader(fileLocation))
            {
                var songList = new List<string>();

                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "title")
                    {
                        var songTitle = reader.ReadElementString();

                        if (!songList.Contains(songTitle))
                        {
                            songList.Add(songTitle);
                            Console.WriteLine(songTitle);
                        }
                    }
                }
            }
        }

        public static void WithXDocumentLinq(string fileLocation)
        {
            Console.WriteLine("All song titles in the document using XDocument and LINQ: \n");

            var doc = XDocument.Load(fileLocation);

            var titles = from title in doc.Descendants("title") select title.Value;
            // removes duplicate entries
            titles = titles.GroupBy(x => x).Select(y => y.First());
            Console.WriteLine(string.Join("\r\n", titles));
        }
    }
}
