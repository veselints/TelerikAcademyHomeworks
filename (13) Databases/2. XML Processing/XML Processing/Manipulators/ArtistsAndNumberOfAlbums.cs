namespace XML_Processing
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    public class ArtistsAndNumberOfAlbums
    {
        public static void GetWithDOMParser(string fileLocation)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(fileLocation);
            var root = doc.DocumentElement;

            var artistsList = new Dictionary<string, int>();

            foreach (XmlNode node in root.ChildNodes)
            {
                var artist = node["artist"].InnerText;
                if (artistsList.ContainsKey(artist))
                {
                    artistsList[artist]++;
                }
                else
                {
                    artistsList.Add(artist, 1);
                }
            }

            Console.WriteLine("Artists and the number of produced albums Using DOM-Parser:\n");
            foreach (var entry in artistsList)
            {
                Console.WriteLine("{0} has {1} albums in the catalog!", entry.Key, entry.Value);
            }
        }

        public static void GetWithXPath(string fileLocation)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(fileLocation);

            var artistsList = new Dictionary<string, int>();

            var queryPath = "/catalogue/album/artist";

            XmlNodeList artists = doc.SelectNodes(queryPath);

            foreach (XmlNode artistNode in artists)
            {
                var artist = artistNode.InnerText;

                if (artistsList.ContainsKey(artist))
                {
                    artistsList[artist]++;
                }
                else
                {
                    artistsList.Add(artist, 1);
                }
            }

            Console.WriteLine("Artists and the number of produced albums Using xPath:\n");
            foreach (var entry in artistsList)
            {
                Console.WriteLine("{0} has {1} albums in the catalog!", entry.Key, entry.Value);
            }
        }
    }
}
