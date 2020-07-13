using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReadRssFeedInAspnetCore.Models
{
    public class Item
    {
        public string title { get; set; }

        public string description { get; set; }

        public string link { get; set; }


        public string guid { get; set; }

        public string Category { get; set; }

        public string Pubdate { get; set; }
    }
}
