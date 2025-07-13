using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalBudgetAppWithUI.Models;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;

namespace PersonalBudgetAppWithUI.ViewModels;

public partial class AccountsScreenViewModel : ViewModelBase
{

    [ObservableProperty]
    private ObservableCollection<Account> accounts = new ObservableCollection<Account>();


    [ObservableProperty]
    private string? newAccountName;

    [ObservableProperty]
    private string? newAccountInstitution;

    [ObservableProperty]
    private string? newAccountType;

    [ObservableProperty]
    private decimal? newAccountBalance;

    // METHODS

    // a method that is wired to a button to add a new account that has a can execute thing
    [RelayCommand]
    public void AddAccount()
    {
        if (!string.IsNullOrWhiteSpace(NewAccountName) &&
            !string.IsNullOrWhiteSpace(NewAccountInstitution) &&
            !string.IsNullOrWhiteSpace(NewAccountType) &&
            NewAccountBalance.HasValue && NewAccountBalance.Value >= 0)
        {
            Account newAccount = null;

            if(NewAccountType == "Checking")
            {
                newAccount = new CheckingAccount(
                    NewAccountName,
                    NewAccountInstitution,
                    NewAccountBalance.Value);

            }
            else if (NewAccountType == "Savings")
            {
                newAccount = new SavingsAccount(
                    NewAccountName,
                    NewAccountInstitution,
                    NewAccountBalance.Value);
            }

            Accounts.Add(newAccount);
        }
    }



}
