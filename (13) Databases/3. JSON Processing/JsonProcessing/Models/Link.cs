using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JsonProcessing
{
    public class Link
    {
        [JsonProperty("@rel")]
        public string rel { get; set; }

        [JsonProperty("@href")]
        public string href { get; set; }
    }
}
