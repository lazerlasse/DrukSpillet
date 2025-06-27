using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using DrukSpillet.ViewModels;
using DrukSpillet.Pages; // Ensure this is the correct namespace for the toolkit

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

            // Registering Pages
            builder.Services.AddTransient<HomePage>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
