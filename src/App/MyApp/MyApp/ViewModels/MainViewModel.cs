using System.ComponentModel;

namespace MauiApp1.ViewModels;

public class MainViewModel : INotifyPropertyChanged
{
    private string _pageTitle = "Main Page";


    public string PageTitle
    {
        get { return _pageTitle; }
        set
        {
            if (_pageTitle != value)
            {
                _pageTitle = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PageTitle)));
            }
        }
    }


    public event PropertyChangedEventHandler PropertyChanged;
}
