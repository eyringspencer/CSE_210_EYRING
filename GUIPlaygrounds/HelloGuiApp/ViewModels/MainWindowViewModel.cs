using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace HelloGuiApp.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty]
    private string greeting = "Hello From your ViewModel";

    [RelayCommand]
    private void ChangeGreeting()
    {
        Greeting = "You Clicked the Button!";
    }
}
