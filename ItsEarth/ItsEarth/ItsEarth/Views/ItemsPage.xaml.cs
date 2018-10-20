using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using ItsEarth.Models;
using ItsEarth.Views;
using ItsEarth.ViewModels;

namespace ItsEarth.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel viewModel;
        DisasterViewModel DViewModel;
        public List<Disasters> disasters = new List<Disasters>
        {
            new Disasters{Name="Earthquake", Description = "Shake Shake",logo =  "Resources/Logotst1.jpg" },
            new Disasters {Name="Tsuname", Description = "Qater water", logo = "Resources/Logotst2.jpg" },
            new Disasters {Name = "Hurrican", Description = "Wind Wind", logo = "Resources/Logotst3.jpg"}
        };
        public List<Bag> YourBags = new List<Bag>
        {
            new Bag{Name="Save Yourself"},
            new Bag {Name="take me with You"},
            new Bag {Name = "Dont leave me behind"}
        };


        public ItemsPage()
        {
            InitializeComponent();

            DisastersListView.ItemsSource = disasters.OrderByDescending(i =>i.Id).ToList();
            YourListViews.ItemsSource = YourBags.OrderByDescending(i => i.Id).ToList();
            //Carousel1.ItemsSource = disasters.OrderByDescending(i => i.Id).ToList();

            BindingContext = viewModel = new ItemsViewModel();
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Item;
            if (item == null)
                return;

            await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(item)));

            // Manually deselect item.
            //ItemsListView.SelectedItem = null;
        }

        async void AddItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewItemPage()));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Items.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }
    }
}