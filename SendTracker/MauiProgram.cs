﻿using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using SendTracker.Data;
using SendTracker.ViewModel;
using SendTracker.Views;

namespace SendTracker;

public static class MauiProgram {
    public static MauiApp CreateMauiApp() {
        MauiAppBuilder builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts => {
                fonts.AddFont("Nunito-Regular.ttf", "NunitoRegular");
                fonts.AddFont("Nunito-Bold.ttf", "NunitoBold");
            });

        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<MainViewModel>();

        builder.Services.AddSingleton<SettingsPage>();
        builder.Services.AddSingleton<SettingsPageViewModel>();

        builder.Services.AddTransient<NewRoutePage>();
        builder.Services.AddTransient<NewRouteViewModel>();

        builder.Services.AddTransient<RoutePage>();
        builder.Services.AddTransient<RoutePageViewModel>();

        builder.Services.AddSingleton<RoutesDatabase>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}