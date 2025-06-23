public class ChecklistGoal : Goal
{
    //Attributes and Properties
    private int _bonusPoints;

    private int _eventCount;

    private int _completionCount;


    //Constructors

    public ChecklistGoal(string name, string description, int points, int completionCount, int bonusPoints) : base(3, name, description, points)
    {
        _completionCount = completionCount;

        _bonusPoints = bonusPoints;

        _eventCount = 0;
    }

    //Methods

    public override void RecordEvent(GoalTracker tracker)
    {
        _eventCount += 1;
        if (_eventCount != _completionCount)
        {
            tracker.Score += Points;
        }
        else
        {
            tracker.Score += Points;
            tracker.Score += _bonusPoints;
            IsComplete = true;
        }
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

        return $"{completionMarker} {Name} ({Description}) - Event Count: {_eventCount}/{_completionCount}";

    }
    
    
}





// ///<summary>
// /// A child class of goal for eternal goals that are marked complete after a certain number of events recorded
// /// </summary>

// public class ChecklistGoal : Goal
// {
//     //Attributes

//     //Properties
//     public int CompleteCount { get; set; }

//     public int BonusPoints { get; set;}

//     //Constructors
//     public ChecklistGoal(string name, string description, int points, int completeCount, int bonusPoints) : base("Checklist Goal", name, description, 0, points)
//     {
//         CompleteCount = completeCount;
//         BonusPoints = bonusPoints;
//     }

//     //Methods


// }