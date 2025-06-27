using System.Dynamic;

public class GoalTracker
{
    //Attributes and Properties
    public List<Goal> Goals { get; set; } = new List<Goal>();

    public int Score { get; set; }

    // Constructors
    public GoalTracker(int score)
    {
        Score = score;
    }

    //Methods

    //save method
    public void Save(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine(Score);
            foreach (Goal goal in Goals)
            {
                writer.WriteLine(goal.Serialize());
            }
        }

    }
    //load method

    public void Load(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);

        Score = int.Parse(lines[0]);
        Goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split(':');
            int goalType = int.Parse(parts[0]);

            Goal goal;
            switch (goalType)
            {
                case 1:
                    goal = SimpleGoal.Deserialize(line);
                    break;
                case 2:
                    goal = EternalGoal.Deserialize(line);
                    break;
                case 3:
                    goal = ChecklistGoal.Deserialize(line);
                    break;
                default:
                    continue;
            }

            Goals.Add(goal);

        }
        
  

    }



}