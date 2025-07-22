using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalBudgetAppWithUI.Models;
using PersonalBudgetAppWithUI.Services;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;

namespace PersonalBudgetAppWithUI.ViewModels;

public partial class AccountsScreenViewModel : ViewModelBase
{
    public ObservableCollection<Account> Accounts => DataManager.Instance.Accounts;

    

    [ObservableProperty]
    private string? newAccountName;

    [ObservableProperty]
    private string? newAccountInstitution;

    [ObservableProperty]
    private string? newAccountType;

    [ObservableProperty]
    private decimal? newAccountBalance;

    [ObservableProperty]
    private string addAccountButtonText = "Add Account";

    [ObservableProperty]
    private Account? selectedAccount;

    public ObservableCollection<string> AccountTypes { get; } = new ObservableCollection<string>
    {
        "Checking",
        "Savings"
    };

    //Navigation action to go back to the home screen
    public Action? navigateToHomeScreen { get; set; }

    // METHODS

    // a method that is wired to a button to add a new account that has a can execute thing
    [RelayCommand]
    public void AddAccount()
    {

        //check if the button is in add or update mode
        if (AddAccountButtonText == "Update Account")
        {

            //ensure that all information is provided
            if (!string.IsNullOrWhiteSpace(NewAccountName) &&
            !string.IsNullOrWhiteSpace(NewAccountInstitution) &&
            !string.IsNullOrWhiteSpace(NewAccountType) &&
            NewAccountBalance.HasValue && NewAccountBalance.Value >= 0 &&
            SelectedAccount != null)
            {
                DataManager.Instance.Accounts.Remove(SelectedAccount);

                Account updatedAccount = null;

                if (NewAccountType == "Checking")
                {
                    updatedAccount = new CheckingAccount(
                        NewAccountName,
                        NewAccountInstitution,
                        NewAccountBalance.Value);
                }

                else if (NewAccountType == "Savings")
                {
                    updatedAccount = new SavingsAccount(
                        NewAccountName,
                        NewAccountInstitution,
                        NewAccountBalance.Value);
                }

                if (updatedAccount != null)
                {
                    DataManager.Instance.Accounts.Add(updatedAccount);
                }

                //save 
                DataManager.Instance.SaveData();

                //reset and clear
                AddAccountButtonText = "Add Account";
                NewAccountName = String.Empty;
                NewAccountInstitution = String.Empty;
                NewAccountType = String.Empty;
                NewAccountBalance = null;
                SelectedAccount = null;
            }




                    


        }

        else
        {
            if (!string.IsNullOrWhiteSpace(NewAccountName) &&
            !string.IsNullOrWhiteSpace(NewAccountInstitution) &&
            !string.IsNullOrWhiteSpace(NewAccountType) &&
            NewAccountBalance.HasValue && NewAccountBalance.Value >= 0)
            {
                Account newAccount = null;

                if (NewAccountType == "Checking")
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

                if (newAccount != null)
                {
                    DataManager.Instance.Accounts.Add(newAccount);
                    DataManager.Instance.SaveData();
                    // Clear the input fields after adding the account
                    NewAccountName = string.Empty;
                    NewAccountInstitution = string.Empty;
                    NewAccountType = string.Empty;
                    NewAccountBalance = null;
                }
            }
        }
        
    }


    [RelayCommand]
    public void BackToHomeScreen()
    {
        navigateToHomeScreen?.Invoke();
    }

    private bool CanDeleteAccount()
    {
        return SelectedAccount != null;
    }   

    private bool CanEditAccount()
    {
        return SelectedAccount != null;
    }

    partial void OnSelectedAccountChanged(Account? value)
    {
        EditAccountCommand.NotifyCanExecuteChanged();
        DeleteAccountCommand.NotifyCanExecuteChanged();
    }


    [RelayCommand (CanExecute = nameof(CanEditAccount))]
    public void EditAccount()
    {
        // assign the input fields to the selected account properties
        NewAccountName = SelectedAccount.Name;
        NewAccountInstitution = SelectedAccount.Institution;
        NewAccountType = SelectedAccount.AccountType;
        NewAccountBalance = SelectedAccount.Balance;

        // change the button content 
        AddAccountButtonText = "Update Account";




    }

    [RelayCommand (CanExecute = nameof(CanDeleteAccount))]
    public void DeleteAccount() 
    { 
        if (SelectedAccount != null)
        {
            DataManager.Instance.Accounts.Remove(SelectedAccount);
            DataManager.Instance.SaveData();
            SelectedAccount = null;
        }
    }

}