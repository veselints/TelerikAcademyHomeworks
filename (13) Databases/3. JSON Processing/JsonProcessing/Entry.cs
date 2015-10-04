using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Net;
using System.Xml;
using Formatting = Newtonsoft.Json.Formatting;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Linq;
using System.Text;

namespace JsonProcessing
{
    class Entry
    {
        static void Main()
        {
            string rssUrl = "https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw";
            DonwloadTelerikRss(rssUrl);

            string xmlLocation = "../../downloads/rss.xml";
            ConvertXmlToJson(xmlLocation);

            string rssJsonLocation = "../../downloads/jsonRss.json";
            GetAllVideoTitles(rssJsonLocation);

            var videosList = ParseVideosJsonToPoco(rssJsonLocation);

            string[] titlesArray = videosList.Select(x => x.title).ToArray();
            string[] urlsArray = videosList.Select(x => x.mediaGroup.mediaContent.url).ToArray();

            var html = GetVideosHtml(titlesArray, urlsArray);
            File.WriteAllText("../../downloads/videos.html", html);
        }

        public static string GetVideosHtml(string[]titlesArray, string[] urlsArray)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("<!DOCTYPE html>\n");
            sb.Append("<html>\n");
            sb.Append("<head>\n");
            sb.Append("<meta charset=\"utf-8\">\n");
            sb.Append("</head>\n");
            sb.Append("<body>\n");

            sb.Append("<TABLE>\n");
            for (int i = 0; i < titlesArray.Length; i++)
            {
                sb.Append("<TR>\n");
                sb.Append("<TD>");
                sb.Append("<a href=\"" + urlsArray[i] + "\"><span>" + titlesArray[i] + "</span></a>");
                sb.Append("</TD>\n");
                sb.Append("<TD>");
                sb.Append("<iframe src=\"" + urlsArray[i] + "\"><p>Your browser does not support iframes.</p></iframe>");
                sb.Append("</TD>\n");
                sb.Append("</TR>\n");
            }

            sb.Append("</TABLE>");
            sb.Append("</body>\n");
            sb.Append("</html>\n");

            return sb.ToString();
        }

        private static List<Video> ParseVideosJsonToPoco(string rssJsonLocation)
        {
            List<Video> videosList = new List<Video>();
            using (StreamReader reader = new StreamReader(rssJsonLocation))
            {
                string loadedJsonString = reader.ReadToEnd();
                JObject parsedJsonFromFile = JObject.Parse(loadedJsonString);

                var videos = parsedJsonFromFile["feed"]["entry"].Children();

                foreach (var video in videos)
                {
                    var currentVideo = JsonConvert.DeserializeObject<Video>(video.ToString());
                    videosList.Add(currentVideo);
                    Console.WriteLine(currentVideo.title + " has " + currentVideo.mediaGroup.mediaCommunity.mediaStatistics.views + " views!");
                }
            }

            Console.WriteLine("\n\n");

            return videosList;
        }

        private static void GetAllVideoTitles(string rssJsonLocation)
        {
            using (StreamReader reader = new StreamReader(rssJsonLocation))
            {
                string loadedJsonString = reader.ReadToEnd();
                JObject parsedJsonFromFile = JObject.Parse(loadedJsonString);

                var titles = parsedJsonFromFile["feed"]["entry"].Children()["title"].Values<string>();

                foreach (var title in titles)
                {
                    Console.WriteLine(title);
                }

            }
            Console.WriteLine("\n\n");
        }

        private static void ConvertXmlToJson(string xmlLocation)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlLocation);
            string jsonText = JsonConvert.SerializeXmlNode(doc, Formatting.Indented);

            File.WriteAllText("../../downloads/jsonRss.json", jsonText);
            Console.WriteLine("Successfully saved File jsonRss.json in directory ../../downloads!\n\n");

        }

        private static void DonwloadTelerikRss(string rssUrl)
        {
            string saveFileLocation = "../../downloads/rss.xml";

            WebClient myWebClient = new WebClient();

            Console.WriteLine("Downloading File rss.xml from \"{0}\" .......\n\n", rssUrl);

            myWebClient.DownloadFile(rssUrl, saveFileLocation);
            Console.WriteLine("Successfully Downloaded File rss.xml from \"{0}\"", rssUrl);
            Console.WriteLine("\nDownloaded file saved in the following file system folder: " + saveFileLocation + "\n\n");
        }
    }
}
