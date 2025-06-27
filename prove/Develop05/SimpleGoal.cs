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

    public override string Serialize()
    {
        return $"{GoalType}:{Name},{Description},{Points},{IsComplete}";
    }

    public static Goal Deserialize(string line)
    {
        string[] parts = line.Split(':');

        string[] fields = parts[1].Split(',');

        string name = fields[0];
        string description = fields[1];
        int points = int.Parse(fields[2]);
        bool isComplete = bool.Parse(fields[3]);

        SimpleGoal goal = new SimpleGoal(name, description, points)
        {
            IsComplete = isComplete
        };

        return goal;
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