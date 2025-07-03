using DrukSpillet.ViewModels.TruthOrDare;

namespace DrukSpillet.Pages.TruthOrDare;

public partial class TruthOrDareStartPage : ContentPage
{
	public TruthOrDareStartPage(TruthOrDareStartPageViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;
    }
}