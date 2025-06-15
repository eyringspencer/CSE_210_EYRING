using System.Runtime.InteropServices;

public class Listing : Activity
{
    // Attributes

    List<string> _prompts;

    // Constructors
    public Listing(int duration) : base("Listing", "reflect on the good things in your life by having you list as many things as you can in a certain area.", duration, "Well Done!")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heros?"
        };
    }

    // Methods

    public string GetPrompt()
    {
        Random rand = new Random();
        int i = rand.Next(_prompts.Count);
        return _prompts[i];
    }

}