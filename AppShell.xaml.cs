using DrukSpillet.Pages.BackAgainstBack;
using DrukSpillet.Pages.NeverHaveIEver;
using DrukSpillet.Pages.TruthOrDare;

namespace DrukSpillet
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(BackAgainstBackStartPage), typeof(BackAgainstBackStartPage));
            Routing.RegisterRoute(nameof(NeverHaveIEverStartPage), typeof(NeverHaveIEverStartPage));
            Routing.RegisterRoute(nameof(TruthOrDareStartPage), typeof(TruthOrDareStartPage));
        }
    }
}
