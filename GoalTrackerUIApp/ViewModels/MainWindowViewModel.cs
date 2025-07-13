using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GoalTrackerUIApp.Models;
using System.Collections.ObjectModel;

namespace GoalTrackerUIApp.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{

    private GoalTracker _tracker;

    

    [ObservableProperty]
    private int score;

    public ObservableCollection<Goal> Goals { get; set; } = new();

    private void CreateSampleGoal()
    [RelayCommand]
    {
        var goal = new SimpleGoal("NewSimpleGoal", "Demo Goal", 100);
    }

    [RelayCommand]
    private void RecordGoal(Goal goal)
    {
        goal.RecordEvent(_tracker);
        Score = _tracker.Score;
    }

}
