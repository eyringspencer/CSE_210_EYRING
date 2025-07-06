using System;
using System.Windows.Input;
using Avalonia.Controls.ApplicationLifetimes;
using CommunityToolkit.Mvvm.Input;

namespace MyBudgetApp.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public ICommand NewBudgetCommand { get; }

    public MainWindowViewModel()
    {
        NewBudgetCommand = new RelayCommand(ExecuteNewBudget);
    }

    private void ExecuteNewBudget()
    {
        Console.WriteLine("NewBudgetButtonClicked!");
    }
}
