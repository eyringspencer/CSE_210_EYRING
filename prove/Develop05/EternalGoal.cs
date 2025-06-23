
using System.Diagnostics.Tracing;

public class EternalGoal : Goal
{
    //Properties and Attributes
    public int EventCount { get; set; }

    //Constructors
    public EternalGoal(string name, string description, int points) : base(2, name, description, points)
    {
        EventCount = 0;
    }



    //Methods
    public override void RecordEvent(GoalTracker tracker)
    {
        EventCount += 1;
        tracker.Score += Points;
    }

    public override string GetStatus()
    {
        if (EventCount != 0)
        {
            return $"[ ] {Name} ({Description}) - Event Count: {EventCount}";
        }
        else
        {
            return $"[ ] {Name} ({Description})";
        }
    }

    //serialize method here
    
    //deserialize method here
    


} 





















// ///<summary>
// /// A child class of goal for eternal goals
// /// </summary>

// public class EternalGoal : Goal
// {
//     //Attributes

//     //Properties

//     //Constructors
//     public EternalGoal(string name, string description, int points) : base("Eternal Goal", name, description, 0, points)
//     {
        
//     }

//     //Methods


// }