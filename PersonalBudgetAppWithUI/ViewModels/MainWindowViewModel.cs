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

            //code can go here to load prelim and initialization code
            ShowHome();
        }

        [RelayCommand]
        private void ShowHome()
        {

            var homeViewModel = new HomeScreenViewModel();
            homeViewModel.navigateToAccounts = ShowAccountsScreen;
            homeViewModel.NavigateToBudgetsScreen = ShowBudgetsScreen;
            CurrentView = new HomeScreen
            {
                DataContext = homeViewModel
            };
        }

        [RelayCommand]
        private void ShowAccountsScreen()
        {
            var accountsViewModel = new AccountsScreenViewModel();
            accountsViewModel.navigateToHomeScreen = ShowHome;

            CurrentView = new AccountsScreen
            {
                DataContext = accountsViewModel
            };
        }


        [RelayCommand]
        private void ShowBudgetsScreen()
        {
            var budgetsScreenViewModel = new BudgetsScreenViewModel();
            budgetsScreenViewModel.NavigateToHomeScreen = ShowHome;
            budgetsScreenViewModel.NavigateToAddBudgetScreen = ShowAddBudgetScreen;
            CurrentView = new BudgetsScreen
            {
                DataContext = budgetsScreenViewModel
            };
        }

        [RelayCommand]
        private void ShowAddBudgetScreen()
        {
            var addBudgetScreenViewModel = new AddBudgetScreenViewModel();
            addBudgetScreenViewModel.NavigateToBudgetsScreen = ShowBudgetsScreen;
            CurrentView = new AddBudgetScreen
            {
                DataContext = addBudgetScreenViewModel
            };
        }

    }
}
