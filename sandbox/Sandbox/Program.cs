using System;

class Program
{
    static void Main(string[] args) 
    {
        // these are examples of the primitive types in c#
        // See this for other types https://www.google.com/search?q=c%23+primitive+types&rlz=1C1RXQR_enUS1131US1131&oq=c%23+primitive+types&gs_lcrp=EgZjaHJvbWUyCQgAEEUYORiABDIHCAEQABiABDIICAIQABgWGB4yCAgDEAAYFhgeMggIBBAAGBYYHjIICAUQABgWGB4yCAgGEAAYFhgeMgYIBxBFGDrSAQgzMjY5ajBqN6gCALACAA&sourceid=chrome&ie=UTF-8
        int a = 3;
        string s = "Goodbye";
        string s2 = "Goodbye";
        float f  = 3.14F; /* the F tells the computer to really treat this as a float. Without it you're trying to stuff a double into a 32 bit float format. It doesn't have to be capital F, but Brother Barzee likes that a bit better because it's standard for when he writes hexidecimal code */
        double d = 5.21;

        // THIS IS A PROGRAM TO COMPUTE THE AREA OF A CIRCLE

        // Get the radius of the circle from the user
        Console.WriteLine("Please enter the radius: ");
        string input_text = Console.ReadLine();
        double radius = double.Parse(input_text); // parse just means "interpret this string somehow

        // Compute the area
        double area = Math.PI * radius * radius; // this is essentially writing radius^2, but programmers typically would do it this way.

        // Display the area for the user to see
        Console.WriteLine($"Area of the circle: {area}");
    }
}