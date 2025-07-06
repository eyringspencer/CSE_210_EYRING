using Avalonia.Controls;
using ToDoListApp.ViewModels;

namespace ToDoListApp.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel();
    }
}