using CommunityToolkit.Mvvm.Input;
using DrukSpillet.Pages.BackAgainstBack;
using DrukSpillet.Pages.NeverHaveIEver;
using DrukSpillet.Pages.TruthOrDare;
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
            Title = "Vælg Spil";
            IsBusy = false; // Initialize IsBusy to false
        }

        [RelayCommand]
        public async Task PlayBackAgainstBack()
        {
            await Shell.Current.GoToAsync(nameof(BackAgainstBackStartPage));
        }

        [RelayCommand]
        public async Task PlayTruthOrDareAsync()
        {
            await Shell.Current.GoToAsync(nameof(TruthOrDareStartPage));
        }

        [RelayCommand]
        public async Task PlayNeverHaveIEverAsync()
        {
            await Shell.Current.GoToAsync(nameof(NeverHaveIEverStartPage));
        }
    }
}
