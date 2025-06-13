public class Breathing : Activity
{
    // Attributes

    private string _breatheIn = "Breathe in...";

    private string _breatheOut = "Now Breathe Out";


    // Constructors

    public Breathing(int duration) : base("Breathing", "relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", duration, "Well done!!")
    {

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