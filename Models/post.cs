using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazorConfigure1.Models
{
    public class post
    {
        public int id { get; set; }
        public string title { get; set; }
        public string text { get; set; }
        public DateTime date { get; set; } = DateTime.Now;
    }
}
