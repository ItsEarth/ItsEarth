using System;
using System.Collections.Generic;
using System.Text;

namespace ItsEarth.Models
{
    public  class Disasters
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Bag BagPattern { get; set; }
        public List<string> midia { get; set; }
    }
}
