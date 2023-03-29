using Autofac;
using MauiApp1.ViewModels;

namespace MyApp.Views;

public partial class MainPage : ContentPage
{
	public MainPage(MainViewModel mainViewModel)
	{
		InitializeComponent();

        BindingContext = App.Container.Resolve<MainViewModel>();
        // BindingContext = mainViewModel;
    }
}