using System;
using System.Collections.Generic;
using System.Text;

namespace ItsEarth.Models
{
    public enum MenuItemType
    {
        Profile,
        Infos,
        Guides,
        WhereToGo,
        About
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
