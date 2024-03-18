using AllAboutCatsApp.Services;
using AllAboutCatsApp.Views;
using Microsoft.Extensions.Logging;

namespace AllAboutCatsApp
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
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<Authentication>();
            builder.Services.AddSingleton<LoadingPage>();

            builder.Services.AddSingleton<Alert>();
            return builder.Build();
        }
    }
}
