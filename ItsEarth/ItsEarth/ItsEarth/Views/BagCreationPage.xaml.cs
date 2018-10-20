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
		public BagCreationPage ()
		{

            InitializeComponent ();
            HealthStack.Children.Add(new Image { Source = "firstaid1.png" });
            HealthStack.Children.Add(new Image { Source = "firstaid1.png" });
            HealthStack.Children.Add(new Image { Source = "firstaid1.png" });
            HealthStack.Children.Add(new Image { Source = "firstaid1.png" });
            HealthStack.Children.Add(new Image { Source = "firstaid1.png" });
            HealthStack.Children.Add(new Image { Source = "firstaid1.png" });
            HealthStack.Children.Add(new Image { Source = "firstaid1.png" });
            HealthStack.Children.Add(new Image { Source = "firstaid1.png" });
            HealthStack.Children.Add(new Image { Source = "firstaid1.png" });





        }
    }
}