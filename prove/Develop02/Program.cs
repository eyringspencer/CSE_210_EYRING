using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.IO.Enumeration;

/* This will be the main program class for the journal assignment.
Classes
 - Journal
 - Entry

 Goal
 - Allow the user to generate journal prompts and add journal entries to a file.
 */
class Program
{
    static void Main(string[] args)
    {
        // display the intro message
        Console.WriteLine("Welcome to your journal.");

        // create a single journal object that will persist throughout the program
        Journal journal = new Journal();

        // create a variable for quitting the loop
        bool quitSelected = false;

        // loop through the code as long as the user doesn't select quit
        do
        {
            // display the menu
            DisplayMenu();

            // get the user's choice
            int selection = GetMenuChoice();

            // act based on the user's selection
            switch (selection)
            {
                // Write: Add a new journal entry
                case 1:
                    AddEntry(journal);
                    break;


                // Display: Display all of the current journal entries
                case 2:
                    journal.Display();
                    break;

                // Load: read an existing file and put those entries into the journal object
                case 3:
                    string loadFileName = GetFileName();
                    journal.Read(loadFileName);
                    break;

                // Save: write the existing journal to a file
                case 4:
                    string saveFileName = GetFileName();
                    journal.Write(saveFileName);
                    break;

                // Quit
                case 5:
                    quitSelected = true;
                    Console.WriteLine("Thank you for using the journal program. Goodbye");
                    break;

                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    break;


            }


        } while (!quitSelected);









        /* Create the function to display the main menu
        Return: Void
        Calls:
        write - AddEntry() from main
        display - Display() from Journal
        Load - Read() from journal
        Save - Write() from journal
        Quit - NA
        */
        static void DisplayMenu()
        {
            // use a string literal to give the menu options
            Console.WriteLine("Please select from the following menu options by entering the number associated with the desired option.");
            Console.WriteLine("""
                1. Write
                2. Display
                3. Load
                4. Save
                5. Quit
            """);
        }

        /* Create the function to get the user's menu choice
        Return: int
        */
        static int GetMenuChoice()
        {
            // ask the user what they would like to do
            Console.Write("What would you like to do?: ");

            // get the choice
            int menuChoice = int.Parse(Console.ReadLine());

            //return the choice as an int
            return menuChoice;


        }

        /* Create the function that will prompt the user to enter a file name to read and write.
        Implementation: This should display either right after the user slects "load" becuase we need to know what file they want to load,
        or it will happen after the user selects save so that we know what to call the saved file.
        Return: string
        */
        static string GetFileName() {
            // ask the user for the file name that they want to deal with for this run of the program 
            Console.Write("Please enter the name and filetype of the file that you would like to use: ");

            // get the user input for the file name
            string fileName = Console.ReadLine();

            // make sure that the file name is formatted correctly
            if (!fileName.EndsWith(".txt")) {
                fileName += ".txt";
            }

            return fileName;

        }


        /* Create a function that will add an entry to the existing journal.
        Implementation: This should be called right after the user selects menu option 1
        Return: Void
        */
        static void AddEntry(Journal journal)
        {
            //create a new entry object
            Entry entry = new Entry();

            // store the current date
            entry.date = DateTime.Now;

            // create an array of Journal prompts
            string[] prompts = {
                "Who was the most interesting person I interacted with today?",
                "What was the best part of my day?",
                "How did I see the hand of the Lord in my life today?",
                "What was the strongest emotion I felt today?",
                "If I had one thing I could do over today, what would it be?",
                "What was the hardest part of today?",
                "What are you proud of from today?"
            };

            // generate a new random prompt for this entry
            Random random = new Random();
            int promptIndex = random.Next(prompts.Length);
            entry.prompt = prompts[promptIndex];

            // display the prompt to the user
            Console.WriteLine($"Prompt: {entry.prompt}");

            // Get the user's response
            Console.Write(">");
            entry.response = Console.ReadLine();

            // add the entry to the persisting journal object
            journal.entries.Add(entry);

            //Confirm to the user that the entry was added successfully
            Console.WriteLine("Entry Added Successfully!");
            
        }

   
    }
}