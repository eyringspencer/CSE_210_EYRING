
using System.ComponentModel;
using System.Runtime.CompilerServices;

public abstract class Goal
{
    // Properties and Attributes

    public int GoalType { get; set; }
    public string Name { get; set; }

    public string Description { get; set; }

    public int Points { get; set; }

    public bool IsComplete { get; set; }

    // Constructors
    public Goal(int goalType, string name, string description, int points)
    {
        GoalType = goalType;
        Name = name;
        Description = description;
        Points = points;
        IsComplete = false;

    }

    //Methods

    public abstract void RecordEvent(GoalTracker tracker);

    public abstract string GetStatus();

    // add serialize and deserialize methods


}























// using System.ComponentModel;
// using System.Runtime.CompilerServices;

// ///<summary>
// /// This is the parent abstract class Goal for all of the goal types
// /// </summary>
// public abstract class Goal
// {
//     //Attributes
//     private bool _completionStatus = false;

//     private string _namePrompt = "What is the name of your goal? > ";
//     private string _descriptionPrompt = "What is a short description of it? > ";
//     //Properties
//     public string GoalType { get; set; }

//     public string Name { get; set; }

//     public string Description { get; set; }

//     public int EventCount { get; set; }

//     public int Points { get; set; }

//     //Constructor
//     public Goal(string goalType, string name, string description, int eventCount, int points)
//     {
//         GoalType = goalType;
//         Name = name;
//         Description = description;
//         EventCount = eventCount;
//         Points = points;

//     }

//     //Methods
//     //public abstract void RecordEvent();

//     //public abstract bool IsComplete();

//     //public abstract string GetFormattedGoalName();
// }