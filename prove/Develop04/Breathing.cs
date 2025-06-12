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
    
    // i think i am going to have seperate animation methods for each of the child classes
}