

using System.Runtime.CompilerServices;

public class Entry
{
    //ATTRIBUTES

    // declare the date time attribute
    public DateTime date;
    
    // declare the string for the prompt
    public string prompt;

    // declare the string that will hold the user's response to the prompt
    public string response;


    //METHODS

    // method to display the strings in the current entry
    public void Display()
    {
        // display the date
        Console.WriteLine($"Date: {date.ToLongDateString()}");
        // display the prompt
        Console.WriteLine($"Prompt: {prompt}");
        // display the response associated with this entry
        Console.WriteLine($"Response: {response}");
        // two empty lines for console readability
        Console.WriteLine();
        Console.WriteLine();


    }




}