using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ProfileCardApp.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty]
    private string name = "Jordan Sparks";

    [ObservableProperty]
    private int age = 29;

    [ObservableProperty]
    private string bio = "Coffee Lover. Dev-in-training.";

    private readonly List<(string Name, int Age, string Bio)> profiles = new()
    {
         ("Alex Rivera", 34, "Hiker. C# nerd. Loves sushi."),
        ("Jamie Lee", 27, "Musician and frontend wizard."),
        ("Riley Tran", 42, "Cyclist. Cat person. TypeScript convert."),
        ("Taylor West", 30, "Runner, writer, and pizza connoisseur."),
        ("Morgan Quinn", 23, "Game dev and cozy horror enthusiast.")
    };

    private readonly Random rng = new();

    [RelayCommand]
    private void ShuffleProfile()
    {
        var profile = profiles[rng.Next(profiles.Count)];
        Name = profile.Name;
        Age = profile.Age;
        Bio = profile.Bio;
    }
}
