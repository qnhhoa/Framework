using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Rating
    {
        public string Id { get; set; }
        public string User { get; set; }
        public double Rate { get; set; }
        public string Comment { get; set; }
    }
}
