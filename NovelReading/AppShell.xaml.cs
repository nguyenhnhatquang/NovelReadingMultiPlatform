﻿using NovelReading.Sources.Views;
namespace NovelReading;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        //
        Routing.RegisterRoute(nameof(LoadingPage), typeof(LoadingPage));
        Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
        Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
    }
}
