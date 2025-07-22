using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBudgetAppWithUI.ViewModels;

public partial class HomeScreenViewModel : ViewModelBase
{

    [ObservableProperty]
    private ObservableCollection<string> budgets = new();

    public Action? navigateToAccounts { get; set; }

    public Action? NavigateToBudgetsScreen { get; set; }



    //Constructor
    public HomeScreenViewModel()
    {
    }

    [RelayCommand]
    public void ShowAccounts()
    {
        navigateToAccounts?.Invoke();
    }


    [RelayCommand]
    public void ShowBudgetsScreen()
    {
        NavigateToBudgetsScreen?.Invoke();
    }

}
