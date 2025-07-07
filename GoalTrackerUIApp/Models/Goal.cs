
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace GoalTrackerUIApp.Models
{
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

    public abstract string Serialize();

}







}
