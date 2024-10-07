using MauiApp35.Data;
using Microsoft.Extensions.Logging;

namespace MauiApp35
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif

            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "WeatherForecasts.db");

            // Register WeatherForecastService and the SQLite database
            builder.Services.AddSingleton<Itemservice>(
                s => ActivatorUtilities.CreateInstance<Itemservice>(s, dbPath));

            return builder.Build();
        }
    }
}
