namespace XML_Processing
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    public class AlbumsPricedOverTwenty
    {
        public static void Delete(string fileLocation)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(fileLocation);
            var root = doc.DocumentElement;
            var nodesToRemove = new List<XmlNode>();

            foreach (XmlNode node in root.ChildNodes)
            {
                var price = double.Parse(node["price"].InnerText);

                if (price > 20)
                {
                    nodesToRemove.Add(node);
                }
            }

            foreach (XmlNode node in nodesToRemove)
            {
                root.RemoveChild(node);
            }

            Console.WriteLine("catalogueWithDeletedAlbums.xml generated in xml/ !\n");
            doc.Save("../../../xml/" + "catalogueWithDeletedAlbums.xml");
        }
    }
}
