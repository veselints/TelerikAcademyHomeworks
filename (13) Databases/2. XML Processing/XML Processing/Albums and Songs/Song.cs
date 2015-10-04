using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XML_Processing
{
    public class Song
    {
        public Song(string name, double duration)
        {
            this.Title = name;
            this.Duration = duration;
        }

        public string Title { get; set; }
        public double Duration { get; set; }
    }
}
