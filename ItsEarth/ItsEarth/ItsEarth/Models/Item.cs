using System;

namespace ItsEarth.Models
{
    public enum ItemClasstype
    {
        Health,
        Food,
        Fire,
        Construction,
        Clothing
    }

    public class ItemClass
    {
        public ItemClasstype Class { get; set; }
        public string Logo { get; set; }    
    }

    public class Item
    {
        public string Id { get; set; }
        public string Name { get; set; }
        //  public string Text { get; set; }
        public string Description { get; set; }
        public string Logo {get;set;}
        public ItemClasstype ItemClasstype { get; set; }
    }
}