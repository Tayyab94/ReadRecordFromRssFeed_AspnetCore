using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReadRssFeedInAspnetCore.Models
{
    public class Cricket
    {
        public string title { get; set; }

        public string description { get; set; }

        public string link { get; set; }


        public string guid { get; set; }

        public string coverImages { get; set; }

        public string pubDate { get; set; }
    }
}
