using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace PersonalBudgetAppWithUI.Views;

public partial class HomeScreen : UserControl
{
    public HomeScreen()
    {
        InitializeComponent();
        DataContext = new ViewModels.HomeScreenViewModel();
    }
}