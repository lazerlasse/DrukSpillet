using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using DrukSpillet.ViewModels;
using DrukSpillet.Pages;
using DrukSpillet.ViewModels.BackAgainstBack;
using DrukSpillet.ViewModels.NeverHaveIEver;
using DrukSpillet.ViewModels.TruthOrDare;
using DrukSpillet.Pages.BackAgainstBack;
using DrukSpillet.Pages.NeverHaveIEver;
using DrukSpillet.Pages.TruthOrDare; // Ensure this is the correct namespace for the toolkit

namespace DrukSpillet
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit() // Ensure the correct method name and namespace
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            // Regitering ViewModels
            builder.Services.AddTransient<HomePageViewModel>();
            builder.Services.AddTransient<BackAgainstBackStartPageViewModel>();
            builder.Services.AddTransient<NeverHaveIEverStartPageViewModel>();
            builder.Services.AddTransient<TruthOrDareStartPageViewModel>();

            // Registering Pages
            builder.Services.AddTransient<HomePage>();
            builder.Services.AddTransient<BackAgainstBackStartPage>();
            builder.Services.AddTransient<NeverHaveIEverStartPage>();
            builder.Services.AddTransient<TruthOrDareStartPage>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
