public class GoalTracker
{
    //Attributes and Properties
    private List<Goal> _goals = new List<Goal>();

    public string FileName { get; set; }

    public int Score { get; set; }

    // Constructors
    public GoalTracker(string fileName, int score)
    {
        FileName = fileName;
        Score = score;
    }

    //Methods

    //save method
    //load method
}