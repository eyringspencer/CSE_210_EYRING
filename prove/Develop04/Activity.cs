///<summary>
/// This Activity class will serve as the parent class to the other activity classes
/// Attributes:
/// - welcomeText
///     - stores the name of the activity the user is doing
/// - description
///     - stores the text that is in the activity description
/// - Duration
///     - An int that is the number of seconds that the activity will last
/// - endMessage
///     - Stores the text that will be used in the ending message
/// </summary>

public class Activity
{
    // Attributes

    private string _name;

    private string _description;

    private int _duration;

    private string _endMessage;


    // Constructors 

    // default
    public Activity(string name, string description, int duration, string endMessage)
    {
        _name = name;

        _description = description;

        _duration = duration;

        _endMessage = endMessage;
    }

    // Methods

    // return a string that has the welcome message with the name of the activity
    public string GetWelcomeText()
    {
        return $"Welcome to the {_name} Activity.";
    }

    // return the description
    public string GetDescriptionText()
    {
        return $"This activity will help you to {_description}";
    }

    // setter for the duration
    public void SetDuration(int durationSeconds)
    {
        // _duration = durationSeconds
        _duration = durationSeconds;
    }

    // getter for the duration
    public int GetDuration()
    {
        return _duration;
    }

    public string GetEndMessage()
    {
        return _endMessage;
    }

}