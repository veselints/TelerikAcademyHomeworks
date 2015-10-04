using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JsonProcessing
{
    public class MediaStatistics
    {
        [JsonProperty("@views")]
        public string views { get; set; }
    }
}
