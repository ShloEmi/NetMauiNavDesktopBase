using Autofac;
using MauiApp1.ViewModels;

namespace MyApp.Views;

public partial class MainPage1 : ContentPage
{
	public MainPage1()
	{
		InitializeComponent();

        var vm = App.Container.Resolve<MainViewModel>();
        BindingContext = vm;

    }
}