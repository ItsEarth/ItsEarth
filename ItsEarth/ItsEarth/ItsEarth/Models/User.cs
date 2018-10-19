using System;
using System.Collections.Generic;
using System.Text;

namespace ItsEarth.Models
{
    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string MainLocation { get; set; }
        public List<Bag> MyBags { get; set; }
        public List<Bag> YourLocationBags { get; set; }
    }
}
