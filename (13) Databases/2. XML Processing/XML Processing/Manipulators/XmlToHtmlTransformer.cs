namespace XML_Processing
{
    using System;
    using System.Xml.Xsl;

    public class XmlToHtmlTransformer
    {
        public static void Transform(string fileLocation)
        {
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load("../../../xml/catalogue.xslt");
            xslt.Transform(fileLocation, "../../../xml/catalogue.html");
            Console.WriteLine("Catalogue.xml as HTML generated in xml/catalogue.html");
        }
    }
}
