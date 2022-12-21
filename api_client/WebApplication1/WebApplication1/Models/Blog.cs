using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Blog
    {
        public string ID { get; set; }
        public string title { get; set; }
        public string photo { get; set; }
        public string author { get; set; }
        public string content { get; set; }
        public string link_post { get; set; }
    }
}
