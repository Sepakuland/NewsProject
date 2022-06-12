using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsProject.Models
{
    public class News
    {
        public int NewsId { get; set; }
        public string NewsTitle { get; set; }
        public string NewsText { get; set; }
        public string ImageNewsPath { get; set; }
        public string Category { get; set; }
    }
}
