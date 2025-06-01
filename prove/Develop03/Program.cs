using System;

class Program
{
    static void Main(string[] args)
    {
        // create the reference object
        Reference reference = new Reference("Psalms", 23, 1, 6);

        //Create the array for the verses
        string[] verses = {
            "1 The Lord is my shepherd; I shall not want.",
            "2 He maketh me to lie down in green pastures: he leadeth me beside the still waters.",
            "3 He restoreth my soul: he leadeth me in the paths of righteousness for his name's sake.",
            "4 Yea, though I walk through the valley of the shadow of death, I will fear no evil: for thou art with me; thy rod and thy staff they comfort me.",
            "5 Thou preparest a table before me in the presence of mine enemies: thou anointest my head with oil; my cup runneth over.",
            "6 Surely goodness and mercy shall follow me all the days of my life: and I will dwell in the house of the Lord for ever."
        };

        // create the scripture object
        Scripture scripture = new Scripture(reference, verses);

        // loop until the user types quit
        bool quit = false;
        
        Console.WriteLine("Welcome to the Scripture Memorizer!");
        Console.WriteLine();
        Console.Write("Please select a difficulty level for this round.\n1 = will hide 1 word at a time.\n2 = will hide two words at a time.\n3 = will hide 3 words at a time: ");
        int difficulty = int.Parse(Console.ReadLine());

        do
        {

            // clear the console
            Console.Clear();

            //display the full scripture
            Console.WriteLine(scripture.GetDisplayScripture());
            Console.WriteLine();

            // check if all of the words in the scripture are hidden
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("Congratulations, you have memorized the scripture!");
                quit = true;
                break;
            }

            //ask the user what they would like to do
            Console.Write("Press enter to hide random words, or type 'quit' to exit the program: ");
            string userInput = Console.ReadLine();

            // respond to the input
            if (userInput == "")
            {
                scripture.HideRandomWords(difficulty);
            }
            else
            {
                Console.WriteLine("Thanks for practicing scripture memorization!");
                quit = true;
            }





        } while (quit == false);

    }
}