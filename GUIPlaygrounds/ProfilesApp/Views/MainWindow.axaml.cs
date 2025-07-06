using Avalonia.Controls;
using ProfilesApp.ViewModels;

namespace ProfilesApp.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel();
    }
}