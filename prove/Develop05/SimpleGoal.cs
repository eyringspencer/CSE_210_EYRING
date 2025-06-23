public class SimpleGoal : Goal
{
    //Attributes and Properites
    //none

    //Constructor
    public SimpleGoal(string name, string description, int points) : base(1, name, description, points)
    {

    }

    //Methods
    public override void RecordEvent(GoalTracker tracker)
    {
        IsComplete = true;

        tracker.Score += Points;
    }

    public override string GetStatus()
    {
        string completionMarker;

        if (IsComplete)
        {
            completionMarker = "[X] ";
        }
        else
        {
            completionMarker = "[ ]";
        }

        return $"{completionMarker} {Name} ({Description})";
    }

    
}

































// ///<summnary>
// /// This is a derrived class from Goal.
// /// This should be the most basic child class
// /// </summary>

// public class SimpleGoal : Goal
// {
//     //Attributes

//     //Properties

//     //Constructor
//     public SimpleGoal(string name, string description, int points) : base("SimpleGoal", name, description, 0, points)
//     {

//     }

//     //Methods
//     //public override void RecordEvent()
//     //{
//         //EventCount++;
//     //}
    

// }