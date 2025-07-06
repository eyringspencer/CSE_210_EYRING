using CommunityToolkit.Mvvm.ComponentModel;
using ProfilesApp.Models;
using ProfilesApp.Views;
using System;

namespace ProfilesApp.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty]
    private UserProfile profile;

    public MainWindowViewModel()
    {
        profile = new UserProfile
        {
            UserName = "Alice",
            Email = "alice@example.com",
            DateOfBirth = new DateTime(1990, 5, 15),
            IsActive = true
        };
    }
}
