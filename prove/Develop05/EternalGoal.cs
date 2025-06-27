
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

    public override string Serialize()
    {
        return $"{GoalType}:{Name},{Description},{Points},{IsComplete},{EventCount}";
    }

    public static Goal Deserialize(string line)
    {
        string[] parts = line.Split(':');

        string[] fields = parts[1].Split(',');

        string name = fields[0];
        string description = fields[1];
        int points = int.Parse(fields[2]);
        bool isComplete = bool.Parse(fields[3]);
        int eventCount = int.Parse(fields[4]);


        EternalGoal goal = new EternalGoal(name, description, points)
        {
            IsComplete = isComplete,
            EventCount = eventCount
        };

        return goal;
    }


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