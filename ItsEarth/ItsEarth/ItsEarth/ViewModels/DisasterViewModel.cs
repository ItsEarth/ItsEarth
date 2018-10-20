using ItsEarth.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ItsEarth.ViewModels
{
    class DisasterViewModel : BaseViewModel
    {
        public DisasterViewModel()
        {
            Disasters = new ObservableCollection<Disasters>(new[]
            {
                 new Disasters{Name="Earthquake", Description = "Shake Shake",logo =  "Logotst1.jpg" },
                 new Disasters {Name="Tsuname", Description = "Qater water", logo = "Logotst2.jpg" },
                 new Disasters {Name = "Hurrican", Description = "Wind Wind", logo = "Logotst3.jpg"}
            });
        }
        public ObservableCollection<Disasters> Disasters { get; set; }
    }
}
