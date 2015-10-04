using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace JsonProcessing
{
    public class MediaContent : MediaThumbnail
    {
        [JsonProperty("@type")]
        public string type { get; set; }
    }
}
