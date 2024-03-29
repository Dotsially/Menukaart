﻿using CommunityToolkit.Maui;
﻿using Menukaart.DataManagement;
using Menukaart.DataManagement.Menukaart.Model;
using Menukaart.View;
using Menukaart.ViewModel;
using Microsoft.Extensions.Logging;

namespace Menukaart
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .UseMauiMaps()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddSingleton<DatabaseService>();
            builder.Services.AddTransient<DatabasePageView>();
            builder.Services.AddTransient<RouteListPageView>();
            builder.Services.AddTransient<RouteListPageViewModel>();


#if DEBUG
            builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<IGeolocation>(Geolocation.Default);
            builder.Services.AddTransient<MapPageView>();
            return builder.Build();
        }
    }
}
