using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JsonProcessing
{
    public class MediaStarRating
    {
        [JsonProperty("@count")]
        public string count { get; set; }

        [JsonProperty("@average")]
        public string average { get; set; }

        [JsonProperty("@min")]
        public string min { get; set; }

        [JsonProperty("@max")]
        public string max { get; set; }
    }
}
