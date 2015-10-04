using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace XML_Processing
{
    public class OlderThanFiveYearsAlbumPriceSelector
    {
        public static void GetWithXPath(string fileLocation)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(fileLocation);
            var queryPath = "/catalogue/album/price[../year<=2010]";

            XmlNodeList prices = doc.SelectNodes(queryPath);

            Console.WriteLine("Prices of all albums released 5 or more years ago Using XPath: \n");
            foreach (XmlNode price in prices)
            {
                Console.Write(price.InnerText + ", ");
            }
        }

        public static void GetWithLinq(string fileLocation)
        {
            var doc = XDocument.Load(fileLocation);

            var prices = doc.Descendants("album").Where(x => int.Parse(x.Element("year").Value) <= 2010).Select(x => x.Element("price").Value).ToList();

            Console.WriteLine("Prices of all albums released 5 or more years ago Using LINQ: \n");
            Console.WriteLine(string.Join(", ", prices));
        }
    }
}
