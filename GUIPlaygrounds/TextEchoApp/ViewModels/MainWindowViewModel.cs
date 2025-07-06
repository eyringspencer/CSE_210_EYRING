using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace TextEchoApp.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty]
    private string inputText = string.Empty;

    [RelayCommand]
    private void ClearInput()
    {
        InputText = string.Empty;
    }
}
