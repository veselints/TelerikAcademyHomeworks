namespace XML_Processing
{
    using System;
    using System.Text;
    using System.Xml;

    public class AlbumsAndAuthorsFileCreator
    {
        public static void Create(string fileLocation)
        {
            var albumsLocation = "../../../xml/album.xml";

            using (var reader = new XmlTextReader(fileLocation))
            {
                using (var writer = new XmlTextWriter(albumsLocation, Encoding.UTF8))
                {
                    writer.Formatting = Formatting.Indented;
                    writer.IndentChar = '\t';
                    writer.Indentation = 1;

                    writer.WriteStartDocument();
                    writer.WriteStartElement("albums");

                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element && reader.Name == "name")
                        {
                            writer.WriteStartElement("album");
                            writer.WriteStartElement("name");
                            writer.WriteString(reader.ReadElementString());
                            writer.WriteEndElement();
                        }
                        if (reader.NodeType == XmlNodeType.Element && reader.Name == "artist")
                        {
                            writer.WriteStartElement("artist");
                            writer.WriteString(reader.ReadElementString());
                            writer.WriteEndElement();
                            writer.WriteEndElement();
                        }
                    }

                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                }
            }
            Console.WriteLine("Albums and their authors .xml generated in xml/album.xml \n");
        }
    }
}
