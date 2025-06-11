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

    private string _welcomeText;

    private string _description;

    private int _duration;

    private string _endMessage;


    // Constructors 

    // default
    public Activity(string welcomeText, string description, int duration, string endMessage)
    {
        _welcomeText = welcomeText;

        _description = description;

        _duration = duration;

        _endMessage = endMessage;
    }





}