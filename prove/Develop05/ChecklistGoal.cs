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

    public override string Serialize()
    {
        return $"{GoalType}:{Name},{Description},{Points},{IsComplete},{_eventCount},{_completionCount},{_bonusPoints}";
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
        int completionCount = int.Parse(fields[5]);
        int bonusPoints = int.Parse(fields[6]);

        ChecklistGoal goal = new ChecklistGoal(name, description, points, completionCount, bonusPoints)
        {
            IsComplete = isComplete,
            _eventCount = eventCount
        };

        return goal;
    }    
    
}


