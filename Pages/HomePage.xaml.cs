using DrukSpillet.ViewModels;

namespace DrukSpillet.Pages;

public partial class HomePage : ContentPage
{
	public HomePage(HomePageViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;
    }
}