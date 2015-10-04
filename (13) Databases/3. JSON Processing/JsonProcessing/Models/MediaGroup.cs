using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JsonProcessing
{
    public class MediaGroup
    {
        [JsonProperty("media:title")]
        public string mediaTitle { get; set; }

        [JsonProperty("media:content")]
        public MediaContent mediaContent { get; set; }

        [JsonProperty("media:thumbnail")]
        public MediaThumbnail mediaThumbnail { get; set; }

        [JsonProperty("media:description")]
        public string mediaDescription { get; set; }

        [JsonProperty("media:community")]
        public MediaCommunity mediaCommunity { get; set; }
    }
}
