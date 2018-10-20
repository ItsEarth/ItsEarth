using ItsEarth.Models;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ItsEarth.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Guides, Title="Guides" },
                new HomeMenuItem {Id = MenuItemType.Infos, Title="Info" },
                new HomeMenuItem {Id = MenuItemType.Profile, Title="Your Profile" },
                new HomeMenuItem {Id = MenuItemType.WhereToGo, Title="Where To Go" },
                new HomeMenuItem {Id = MenuItemType.About, Title="About Us" }
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            { 
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}