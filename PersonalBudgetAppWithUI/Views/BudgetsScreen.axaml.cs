using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace PersonalBudgetAppWithUI.Views;

public partial class BudgetsScreen : UserControl
{
    public BudgetsScreen()
    {
        InitializeComponent();
        DataContext = new ViewModels.BudgetsScreenViewModel();
    }
}