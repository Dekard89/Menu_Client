using ClientMenu.BLL;
using ClientMenu.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Reflection;


namespace ClientMenu
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var ass = Assembly.GetExecutingAssembly();
            var path = $"{ass.GetName().Name}.appsettings.json";

            var builder = MauiApp.CreateBuilder();
            using (var stream = ass.GetManifestResourceStream(path))
            {
                builder.Configuration.AddJsonStream(stream!);
            }

            builder.Services.AddOptions<OriginOptions>()
                .BindConfiguration(OriginOptions.ORIGIN);

            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();
            builder.Services.AddHttpClient();
            builder.Services.AddScoped<DishReceiver>();
#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
