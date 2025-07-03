using DrukSpillet.ViewModels.NeverHaveIEver;

namespace DrukSpillet.Pages.NeverHaveIEver;

public partial class NeverHaveIEverStartPage : ContentPage
{
	public NeverHaveIEverStartPage(NeverHaveIEverStartPageViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;
    }
}