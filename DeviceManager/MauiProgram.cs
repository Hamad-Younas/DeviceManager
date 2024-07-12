using DeviceManager.Services;
using MatBlazor;
using Microsoft.Extensions.Logging;

namespace DeviceManager
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
#endif
            builder.Services.AddSingleton<ThemeService>();
            builder.Services.AddSingleton<DevicesService>();
            builder.Services.AddSingleton<AdminAccessService>();
            builder.Services.AddSingleton<FileService>();
            builder.Services.AddSingleton<NotificationService>();
            builder.Services.AddSingleton<IntuneService>();
            builder.Services.AddSingleton<OEMInformationService>();
            builder.Services.AddSingleton<RegistryStatusService>();
            builder.Services.AddSingleton<ScreenshotHelper>();


            builder.Services.AddMatBlazor();
            builder.Services.AddMatToaster(config =>
            {
                config.Position = MatToastPosition.BottomRight;
                config.PreventDuplicates = true;
                config.NewestOnTop = true;
                config.ShowCloseButton = true;
                config.MaximumOpacity = 95;
                config.VisibleStateDuration = 5000;
            });
            return builder.Build();
        }
    }
}
