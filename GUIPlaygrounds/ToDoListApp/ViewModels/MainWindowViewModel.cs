using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;


namespace ToDoListApp.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty]
    private string inputText = string.Empty;

    public ObservableCollection<ToDoItem> Tasks { get; } = new();

    [RelayCommand]
    private void AddTask()
    {
        if (!string.IsNullOrWhiteSpace(InputText))
        {
            Tasks.Add(new ToDoItem { Text = InputText });
            InputText = string.Empty;
        }

    }


    [RelayCommand]
    private void DeleteTask(ToDoItem task)
    {
        Tasks.Remove(task);
    }


    [RelayCommand]
    private void EditTask(ToDoItem task)
    {
        task.IsEditing = true;
    }

    [RelayCommand]
    private void SaveEdit(ToDoItem task)
    {
        task.IsEditing = false;
    }
    
}
