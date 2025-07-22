using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PersonalBudgetAppWithUI.Models;
using PersonalBudgetAppWithUI.Services;
namespace PersonalBudgetAppWithUI.ViewModels;

public partial class AddBudgetScreenViewModel : ViewModelBase
{
    // PROPERTIES
    
    // a navigation action to go back to the budgets screen
    public Action? NavigateToBudgetsScreen { get; set; }

    //a property for the income input
    [ObservableProperty]
    private decimal? incomeInput;

    // new budget name
    [ObservableProperty]
    private string newBudgetName = string.Empty;

    // new start date
    [ObservableProperty]
    private DateTime? newStartDate;

    // new end date
    [ObservableProperty]
    private DateTime? newEndDate;



    //income display text
    public string IncomeDisplayText
    {
        get
        {
            if (!IncomeInput.HasValue)
            {
                return $"Entered Income: Not Entered";
            }

            else if (IncomeInput.Value < 0)
            {
                return $"Entered Income: Invalid Amount";
            }

            else
            {
                return $"Entered Income: {IncomeInput.Value:C}";
            }

        }
    }

    // CONSTRUCTOR

    // METHODS


    [RelayCommand]
    public void BacktoBudgetsScreen()
    {
        NavigateToBudgetsScreen?.Invoke();
    }

    //returns the income input text

}
