using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrukSpillet.ViewModels.NeverHaveIEver
{
    public partial class NeverHaveIEverStartPageViewModel : BaseViewModel
    {
        public NeverHaveIEverStartPageViewModel()
        {
            Title = "Jeg Har Aldrig";
            IsBusy = false; // Initialize IsBusy to false
        }
    }
}
