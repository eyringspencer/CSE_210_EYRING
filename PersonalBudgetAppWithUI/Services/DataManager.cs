using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using PersonalBudgetAppWithUI.Models;


namespace PersonalBudgetAppWithUI.Services;

public class DataManager
{
    //PROPERTIES

    //singleton holder
    private static DataManager _instance;

    public static DataManager Instance => _instance ??= new DataManager();

    //Shared collections for budgets and accounts
    public ObservableCollection<Account> Accounts { get; private set;  }

    public ObservableCollection<Budget> Budgets { get; private set; }

    //CONSTRUCTOR

    private DataManager()
    {
        Accounts = new ObservableCollection<Account>();
        Budgets = new ObservableCollection<Budget>();

        //load the data from a file
        LoadData();
    }

    //METHODS

    public void LoadData()
    {
        if (File.Exists("checkingAccountsHistory.json"))
        {
            string jsonCheckingAccountLoadText = File.ReadAllText("checkingAccountsHistory.json");
            
            
            var checkingAccountsFromFile = JsonSerializer.Deserialize<ObservableCollection<CheckingAccount>>(jsonCheckingAccountLoadText);
            
            if (checkingAccountsFromFile != null)
            {
                // add the checking accounts
                foreach (var account in checkingAccountsFromFile)
                {
                    Accounts.Add(account);
                }

                
            }
        }

        if (File.Exists("savingsAccountsHistory.json"))
        {
            string jsonSavingsAccountLoadText = File.ReadAllText("savingsAccountsHistory.json");

            var savingsAccountsFromFile = JsonSerializer.Deserialize<ObservableCollection<SavingsAccount>>(jsonSavingsAccountLoadText);

            if (savingsAccountsFromFile != null)
            {
                foreach (var account in savingsAccountsFromFile)
                {
                    Accounts.Add(account);
                }
            }
        }
    }

    public void SaveData()
    {

        var checkingAccounts = Accounts.OfType<CheckingAccount>();

        var savingsAccounts = Accounts.OfType<SavingsAccount>();

        string jsonCheckingAccountSaveText = JsonSerializer.Serialize(checkingAccounts);
        string jsonSavingsAccountSaveText = JsonSerializer.Serialize(savingsAccounts);

        //write the checking accounts to their own file
        File.WriteAllText("checkingAccountsHistory.json", jsonCheckingAccountSaveText);

        //write the savings accounts to their own file
        File.WriteAllText("savingsAccountsHistory.json", jsonSavingsAccountSaveText);
    }

}
