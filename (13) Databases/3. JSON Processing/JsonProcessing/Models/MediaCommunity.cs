using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JsonProcessing
{
    public class MediaCommunity
    {
        [JsonProperty("media:starRating")]
        public MediaStarRating mediaStarRating { get; set; }

        [JsonProperty("media:statistics")]
        public MediaStatistics mediaStatistics { get; set; }
    }
}
