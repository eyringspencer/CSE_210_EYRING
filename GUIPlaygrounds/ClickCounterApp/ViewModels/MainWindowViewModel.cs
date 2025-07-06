using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ClickCounterApp.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty]
    private int clickCount = 0;

    [RelayCommand]
    private void IncrementClickCount()
    {
        ClickCount++;
    }


    [RelayCommand]
    private void ResetClickCount()
    {
        ClickCount = 0;
    }

    [RelayCommand]
    private void SubtractClickCount()
    {
        ClickCount--;
    }
}
