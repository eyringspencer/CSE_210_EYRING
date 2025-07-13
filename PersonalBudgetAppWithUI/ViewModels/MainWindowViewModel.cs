using System.Collections.ObjectModel;
using Avalonia;
using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PersonalBudgetAppWithUI.Views;

namespace PersonalBudgetAppWithUI.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        [ObservableProperty]
        private UserControl? currentView;

        public MainWindowViewModel()
        {
            CurrentView = new HomeScreen
            {
                DataContext = new HomeScreenViewModel()
            };
        }

        [RelayCommand]
        private void ShowHome()
        {
            CurrentView = new HomeScreen
            {
                DataContext = new HomeScreenViewModel()
            };
        }

        [RelayCommand]
        private void ShowAccountsScreen()
        {
            CurrentView = new AccountsScreen
            {
                DataContext = new AccountsScreenViewModel()
            };
        }

    }
}
