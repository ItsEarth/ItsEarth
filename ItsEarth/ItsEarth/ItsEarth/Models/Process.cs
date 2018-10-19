using System;
using System.Collections.Generic;
using System.Text;

namespace ItsEarth.Models
{
    class Process
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> Images { get; set; }
        public List<string> Videos { get; set; }
    }
}
