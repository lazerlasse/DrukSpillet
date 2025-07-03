using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrukSpillet.ViewModels.TruthOrDare
{
    public partial class TruthOrDareStartPageViewModel : BaseViewModel
    {
        public TruthOrDareStartPageViewModel()
        {
            Title = "Sandhed Eller Konsekvens";
            IsBusy = false; // Initialize IsBusy to false
        }
    }
}
