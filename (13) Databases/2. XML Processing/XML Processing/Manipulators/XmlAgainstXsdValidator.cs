namespace XML_Processing
{
    using System;
    using System.Xml.Linq;
    using System.Xml.Schema;

    class XmlAgainstXsdValidator
    {
        public static void Validate(string fileLocation)
        {
            var schemas = new XmlSchemaSet();
            schemas.Add(string.Empty, "../../../xml/catalogue.xsd");

            XDocument doc = XDocument.Load(fileLocation);

            Console.WriteLine("Validating a " + fileLocation + " XML against XSD results: ");
            
            doc.Validate(schemas, (sender, args) => Console.WriteLine(args.Message));
        }
    }
}
