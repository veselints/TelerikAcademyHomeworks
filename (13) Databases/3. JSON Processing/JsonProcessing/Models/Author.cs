using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JsonProcessing
{
    public class Author
    {
        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("uri")]
        public string uri { get; set; }
    }
}
