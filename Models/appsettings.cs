using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazorConfigure1.Models
{
    public class appsettings
    {
        public Dictionary<string,string> ConnectionStrings { get; set; }
        public Dictionary<string, Dictionary<string, string>> Logging { get; set; }
        public string AllowedHosts { get; set; }
    }
}
