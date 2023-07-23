using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using ShoppingCenter.Libraries.Storages;
using ShoppingCenter.Services;
using ZXing.Net.Maui.Controls;

namespace ShoppingCenter
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
                    fonts.AddFont("OpenSans-Bold.ttf", "OpenSansBold");
                    fonts.AddFont("OpenSans-Light.ttf", "OpenSansLight");
                }).UseMauiCommunityToolkit().UseMauiCommunityToolkitMediaElement().UseBarcodeReader();
            builder.Services.AddSingleton<StoreService>();
            builder.Services.AddSingleton<RestaurantService>();
            builder.Services.AddSingleton<CinemaService>();
            builder.Services.AddSingleton<TicketService>();
            builder.Services.AddSingleton<TicketPreferenceStorage>();
#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}