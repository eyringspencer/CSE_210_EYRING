public class Breathing : Activity
{
    // Attributes

    private string _breatheIn;

    private string _breatheOut;


    // Constructors

    public Breathing(int duration) : base("Breathing", "relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", duration, "Well done!!")
    {
        _breatheIn = "Breathe in...";
        _breatheOut = "Now Breathe Out...";
    }



    //Methods

    // get the breathe in text
    public string GetBreatheIn()
    {
        return _breatheIn;
    }

    // get breathe out text 
    public string GetBreatheout()
    {
        return _breatheOut;
    }

}