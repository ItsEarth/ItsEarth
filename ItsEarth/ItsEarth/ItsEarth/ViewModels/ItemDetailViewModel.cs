using System;

using ItsEarth.Models;

namespace ItsEarth.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
           
            Item = item;
        }
    }
}
