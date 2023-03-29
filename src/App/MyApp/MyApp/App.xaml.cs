using Autofac;
using MauiApp1.ViewModels;
using MyApp.Views;

namespace MyApp;

public partial class App : Application
{
    public static Autofac.IContainer Container { get; private set; }


    public App()
	{
		InitializeComponent();

        // MainPage = new AppShell();
        var builder = new ContainerBuilder();
        builder.RegisterType<MainViewModel>().SingleInstance();
        Container = builder.Build();

        MainPage = new NavigationPage(new MainPage1());

    }
}
