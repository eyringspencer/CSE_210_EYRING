using System.Dynamic;

public class Reflecting : Activity
{
    // Attributes
    private List<string> _prompts;

    private List<string> _followUps;







    // Constructors

    public Reflecting(int duration) : base("Reflecting", "reflect on times in your life when you have shown strength and resilience. This will help you to recognize the power you have and how you can use it in other aspects of your life.", duration, "Well Done!")
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
            "Think of a time that the Lord magnified your efforts.",
            "Think of a time when your prayers were answered.",
            "Think of a time when your faith was increased."

        };

        _followUps = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "Have did you get started?",
            "How did you feel when you were done?",
            "What made this instance different from other times when you were not as successful?",
            "What is your favorite thing about that experience?",
            "What could you learn from that experience that applies to other situations?",
            "What did you learn about your self through that experience?",
            "How can you keep that experience in mind in the future?"
        };

    }

    // Methods
    public string GetPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];

    }

    public string GetFollowUp(int i)
    {
        return _followUps[i];
    }

    public int GetFollowUpCount()
    {
        return _followUps.Count();
    }
}




