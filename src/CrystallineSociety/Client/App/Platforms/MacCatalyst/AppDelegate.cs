﻿using Foundation;

namespace CrystallineSociety.Client.App.Platforms.MacCatalyst;

[Register(nameof(AppDelegate))]
public class AppDelegate : MauiUIApplicationDelegate
{
    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiAppBuilder().Build();
}