using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllAboutCatsApp.Models
{
    internal class CatFacts
    {
    
            public string _id { get; set; }
            public int __v { get; set; }
            public string text { get; set; }
            public DateTime updatedAt { get; set; }
            public bool deleted { get; set; } = false;
        public string source { get; set; } = "api";
            public int sentCount { get; set; }
        

    }
}
