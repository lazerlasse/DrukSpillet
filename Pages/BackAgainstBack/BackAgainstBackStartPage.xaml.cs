using DrukSpillet.ViewModels.BackAgainstBack;

namespace DrukSpillet.Pages.BackAgainstBack;

public partial class BackAgainstBackStartPage : ContentPage
{
	public BackAgainstBackStartPage(BackAgainstBackStartPageViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;
    }
}