using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrukSpillet.ViewModels
{
    public partial class HomePageViewModel : BaseViewModel
    {
        public HomePageViewModel()
        {
            Title = "Forside";
            IsBusy = false; // Initialize IsBusy to false
        }
    }
}
