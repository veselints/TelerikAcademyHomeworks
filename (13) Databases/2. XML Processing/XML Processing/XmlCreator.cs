using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XML_Processing
{
    public class XmlCreator
    {
        public XDocument CreateXml()
        {
            IList<Album> albumsList = GenerateAlbumsObject();

            XDocument document = new XDocument { Declaration = new XDeclaration("1.0", "utf-8", null) };

            var root = new XElement("catalogue");

            document.Add(root);

            foreach (var entry in albumsList)
            {
                var album = new XElement("album",
                    new XElement("name", entry.Name),
                    new XElement("artist", entry.Artist),
                    new XElement("year", entry.Year),
                    new XElement("producer", entry.Producer),
                    new XElement("price", entry.Price));

                var songs = new XElement("songs");

                foreach (var song in entry.Songs)
                {
                    var currSong = new XElement("song",
                        new XElement("title", song.Title),
                        new XElement("duration", song.Duration));

                    songs.Add(currSong);
                }

                album.Add(songs);

                root.Add(album);
            }

            return document;
        }

        private IList<Album> GenerateAlbumsObject()
        {
            Random rand = new Random();
            IList<Album> albums = new List<Album>();

            int albumsCount = Constants.Songs.Length;
            for (int i = 0; i < albumsCount; i++)
            {
                IList<Song> currentSongs = new List<Song>();

                int songsCount = Constants.Songs[i].Length;
                for (int j = 0; j < songsCount; j++)
                {
                    int currentRandom = rand.Next(0, Constants.Lengths.Length);
                    currentSongs.Add(new Song(Constants.Songs[i][j], Constants.Lengths[currentRandom]));
                }

                int year = rand.Next(1965, 2015);
                int priceIndex = rand.Next(0, Constants.Prices.Length);
                albums.Add(new Album(Constants.Albums[i], Constants.Artists[i], year, "BMG", Constants.Prices[priceIndex], currentSongs));
            }

            return albums;
        }
    }
}
