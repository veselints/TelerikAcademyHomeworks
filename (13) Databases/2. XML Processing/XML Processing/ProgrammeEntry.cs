namespace XML_Processing
{
    using System;

    class ProgrammeEntry
    {
        static void Main()
        {
            var fileLocation = "../../../xml/catalogue.xml";

            // Creating XML file
            //var creator = new XmlCreator();
            //var document = creator.CreateXml();
            //document.Save(fileLocation);
            //Console.WriteLine("catalogue.xml generated in xml/ !\n");

            // All the tasks are executed below. If you want to see the properly on the console, execute the one by one.

            ArtistsAndNumberOfAlbums.GetWithDOMParser(fileLocation);
            Console.WriteLine("\n\n");
            ArtistsAndNumberOfAlbums.GetWithXPath(fileLocation);
            Console.WriteLine("\n\n");

            AlbumsPricedOverTwenty.Delete(fileLocation);
            Console.WriteLine("\n\n");

            SongTitlesExtractor.WithXmlReader(fileLocation);
            Console.WriteLine("\n\n");
            SongTitlesExtractor.WithXDocumentLinq(fileLocation);
            Console.WriteLine("\n\n");

            AlbumsAndAuthorsFileCreator.Create(fileLocation);
            Console.WriteLine("\n\n");

            OlderThanFiveYearsAlbumPriceSelector.GetWithXPath(fileLocation);
            Console.WriteLine("\n\n");
            OlderThanFiveYearsAlbumPriceSelector.GetWithLinq(fileLocation);
            Console.WriteLine("\n\n");

            XmlToHtmlTransformer.Transform(fileLocation);
            Console.WriteLine("\n\n");

            XmlAgainstXsdValidator.Validate(fileLocation);
            Console.WriteLine("\n\n");
            XmlAgainstXsdValidator.Validate("../../../xml/invalidCatalog.xml");
            Console.WriteLine("\n\n");

        }
    }
}
