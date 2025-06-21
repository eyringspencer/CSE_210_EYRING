

using System.ComponentModel;
using System.Runtime.CompilerServices;

///<summary>
/// This is the parent abstract class Goal for all of the goal types
/// </summary>
public abstract class Goal
{
    //Attributes
    private bool _completionStatus = false;

    private string _namePrompt = "What is the name of your goal? > ";
    private string _descriptionPrompt = "What is a short description of it? > ";
    //Properties
    public string GoalType { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    //Constructor
    public Goal(string goalType, string name, string description)
    {
        GoalType = goalType;
        Name = name;
        Description = description;
    }

    //Methods
Z
    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public abstract string GetFormattedGoalName();
}