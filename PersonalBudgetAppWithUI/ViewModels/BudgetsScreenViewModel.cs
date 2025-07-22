using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalBudgetAppWithUI.Models;
using PersonalBudgetAppWithUI.Services;

namespace PersonalBudgetAppWithUI.ViewModels;

public partial class BudgetsScreenViewModel : ViewModelBase
{

    [ObservableProperty]
    private ObservableCollection<Budget> budgets = DataManager.Instance.Budgets;

    [ObservableProperty]
    private Budget? selectedBudget;


    public Action? NavigateToHomeScreen { get; set; }

    public Action? NavigateToAddBudgetScreen { get; set; }

    [RelayCommand]
    public void BackToHomeScreen()
    {
        NavigateToHomeScreen?.Invoke();
    }


    [RelayCommand]
    public void AddBudget()
    {
        NavigateToAddBudgetScreen?.Invoke();
    }

}
