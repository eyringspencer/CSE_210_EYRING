using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using PersonalBudgetAppWithUI.ViewModels;

namespace PersonalBudgetAppWithUI.Views;

public partial class AccountsScreen : UserControl
{
    public AccountsScreen()
    {
        InitializeComponent();
        DataContext = new ViewModels.AccountsScreenViewModel();
    }
}