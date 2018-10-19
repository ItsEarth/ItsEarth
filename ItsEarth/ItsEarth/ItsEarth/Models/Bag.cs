using System;
using System.Collections.Generic;
using System.Text;

namespace ItsEarth.Models
{
    public class Bag
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<Item> ItemList { get; set; }
        public string IdDisaster { get; set; }
    }
}
