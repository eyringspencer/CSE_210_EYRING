using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PersonalBudgetAppWithUI.Models;

public class BudgetManager
{
	//FIELDS
	private static BudgetManager _instance;

	private static readonly object _lock = new();


	//PROPERTIES
	public List<Budget> Budgets { get; private set; }

	public List<Account> Accounts { get; private set; }

    public static BudgetManager Instance
	{
		get
		{
			lock (_lock)
			{
				return _instance ??= new BudgetManager();
			}
		}
    }

	//CONSTRUCTOR
	public BudgetManager()
	{
		Budgets = new List<Budget>();
		Accounts = new List<Account>();
    }

    //METHODS
}
