using CommunityToolkit.Mvvm.ComponentModel;
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


    //Constructor
    public HomeScreenViewModel()
    {
        // Initialize the budgets collection with some sample data
        Budgets.Add("Monthly Budget");
        Budgets.Add("Annual Budget");
        Budgets.Add("Savings Budget");
    }

}
