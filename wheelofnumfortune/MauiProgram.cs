using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace wheelofnumfortune;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>().UseMauiCommunityToolkit(static options =>
            {
                options.SetShouldEnableSnackbarOnWindows(true);
                options.SetShouldSuppressExceptionsInConverters(true);
                options.SetShouldSuppressExceptionsInBehaviors(true);
                options.SetShouldSuppressExceptionsInAnimations(true);
            })
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}










