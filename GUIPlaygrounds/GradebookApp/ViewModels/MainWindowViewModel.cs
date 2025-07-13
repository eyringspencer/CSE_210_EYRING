

using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GradebookApp.Models;

namespace GradebookApp.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    // a collection of all of the students
    public ObservableCollection<Student> Students { get; set; } = new();

    // a property for the selected student
    [ObservableProperty]
    private Student? selectedStudent;


    // a property that can be bound to the ui for a new first name
    [ObservableProperty]
    private string newFirstName = string.Empty;

    // a property that can be bound to th ui for a new last name
    [ObservableProperty]
    private string newLastName = string.Empty;

    //a property that can be bound to the ui for a new subject
    [ObservableProperty]
    private string newSubjectName = string.Empty;

    //a property for entering a grade score in the ui
    [ObservableProperty]
    private int score = 0;


    // a method for the add student button
    [RelayCommand]
    public void AddStudent()
    {
        if (!string.IsNullOrWhiteSpace(NewFirstName) && !string.IsNullOrWhiteSpace(NewLastName))
        {
            Student newStudent = new Student(NewFirstName, NewLastName);
            Students.Add(newStudent);
            // clear the inputs 
            NewFirstName = string.Empty;
            NewLastName = string.Empty;
        }

   
    }


    // a Method for the add grade button dependent on there being a selected student
    [RelayCommand]
    public void AddGrade()
    {
        if (SelectedStudent != null && !string.IsNullOrWhiteSpace(NewSubjectName) && Score >= 0)
        {
            Grade newGrade = new Grade(NewSubjectName, Score);
            SelectedStudent.Grades.Add(newGrade);


            NewSubjectName = string.Empty;
            Score = 0;
        }
    }




}
