using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonProcessing
{
    public class Video
    {
        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("yt:videoId")]
        public string videoId { get; set; }

        [JsonProperty("yt:channelId")]
        public string channelId { get; set; }

        [JsonProperty("title")]
        public string title { get; set; }

        [JsonProperty("link")]
        public Link link { get; set; }

        [JsonProperty("author")]
        public Author author { get; set; }

        [JsonProperty("published")]
        public string published { get; set; }

        [JsonProperty("updated")]
        public string updated { get; set; }

        [JsonProperty("media:group")]
        public MediaGroup mediaGroup { get; set; }
    }
}
