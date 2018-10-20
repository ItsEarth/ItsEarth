using ItsEarth.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ItsEarth.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BagCreationPage : ContentPage
	{
        public static List<ItemClass> Categories = new List<ItemClass>
        {
            new ItemClass {Class = ItemClasstype.Health ,Logo = "logotst1.jpg"},
            new ItemClass {Class = ItemClasstype.Clothing, Logo = "logotst2.png"},
            new ItemClass {Class = ItemClasstype.Fire, Logo = "logotst3.png"},
            new ItemClass {Class = ItemClasstype.Construction, Logo = "firstaid1.png"},
            new ItemClass {Class = ItemClasstype.Food, Logo = "iconalert.jpg"}

        };


        public List<Item> Items = new List<Item> {
            new Item {ItemClasstype = ItemClasstype.Health, Logo ="logotst1.jpg" },
            new Item {ItemClasstype = ItemClasstype.Construction, Logo ="logotst1.jpg" },
            new Item {ItemClasstype = ItemClasstype.Fire, Logo ="logotst1.jpg" },
            new Item {ItemClasstype = ItemClasstype.Food, Logo ="logotst1.jpg" },
            new Item {ItemClasstype = ItemClasstype.Clothing, Logo ="logotst1.jpg" },
        };
        public BagCreationPage ()
		{

            InitializeComponent ();
            FillStackLayout(ItemClassSelector, (from x in Categories select x.Logo).ToList());
            ConfigItemSelector();
            HealthStack.Children.Add(new Image { Source = "firstaid1.png"  });
            HealthStack.Children.Add(new Image { Source = "firstaid1.png" });
            HealthStack.Children.Add(new Image { Source = "firstaid1.png" });
            HealthStack.Children.Add(new Image { Source = "firstaid1.png" });
            HealthStack.Children.Add(new Image { Source = "firstaid1.png" });
            HealthStack.Children.Add(new Image { Source = "firstaid1.png" });
            HealthStack.Children.Add(new Image { Source = "firstaid1.png" });
            HealthStack.Children.Add(new Image { Source = "firstaid1.png" });
            HealthStack.Children.Add(new Image { Source = "firstaid1.png" });
        }

        private void ConfigItemSelector()
        {
            var tapGestureRecognizer = new TapGestureRecognizer();
            //			tapGestureRecognizer.NumberOfTapsRequired = 2; // double-tap
            tapGestureRecognizer.Tapped += ClassSelectorTap;
            foreach (Image x in ItemClassSelector.Children)
            {
                x.GestureRecognizers.Add(tapGestureRecognizer); 


            }
        }

       

        private void ClassSelctorAction(object sender, EventArgs e)
        {
            
        }

        private void FillStackLayout(StackLayout x, List<string> image)
        {
            x.Children.Clear();
            foreach(string Y in image)
            {
                x.Children.Add(new Image { Source = Y });
            }
        }

        void ClassSelectorTap(object sender, EventArgs args)
        {
            
            string MyObj;
            string mb = (sender as Image).Source.ToString();
            System.Diagnostics.Debug.WriteLine(mb);
            mb = mb.Split(' ')[1];
            ItemClass cat = Categories.Find(x => x.Logo == mb);
            tst.Text = mb;
            FillStackLayout(ItemList, (from x in Items where x.ItemClasstype == cat.Class select x.Logo).ToList());
        }
        }
}