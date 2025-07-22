using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace PersonalBudgetAppWithUI.Views;

public partial class AddBudgetScreen : UserControl
{
    public AddBudgetScreen()
    {
        InitializeComponent();
        DataContext = new ViewModels.AddBudgetScreenViewModel();
    }
}