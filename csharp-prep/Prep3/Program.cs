using System;
using System.Security.Cryptography;

class Program
{
    static void Main_old(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        

        // CORE REQUIREMENT 1 - COMPARE ENTRIES TO MAGIC NUMBER

        // ask the user for a random number
        Console.Write("Please Enter a Magic Number: ");
        string magicInput = Console.ReadLine();
        int magic = int.Parse(magicInput);


        // ask the user for a guess
        Console.Write("Please Enter a Guess: ");
        string guessInput = Console.ReadLine();
        int guess = int.Parse(guessInput);


        // determine if the user needs to guess higher or lower
        if (guess > magic)
        {
            Console.WriteLine($"{guess} is too high. Guess lower next time!");
        }

        else if (guess < magic)
        {
            Console.WriteLine($"{guess} is too low. Guess higher next time!");
        }

        else
        {
            Console.WriteLine($"The magic number was {magic} and you guessed {guess}. You Guessed it!");
        }


    

    }

    static void Main_2(string[] args)
    {
        //CORE REQUIREMENT 2 - DO REQUIREMENT 1 BUT USE A LOOP THAT KEEPS LOOPING UNTIL THE USER GUESSES CORRECTLY
        
        // ask the user for a random number
        Console.Write("Please Enter a Magic Number: ");
        string  magicInput = Console.ReadLine();
        int magic = int.Parse(magicInput);

        // Loop through Logic
        // declare and initialize comparison variable
        bool isCorrect = false;

        do
        {

             // prompt the user for a guess
            Console.Write("Please Enter a Guess: ");
            string guessInput = Console.ReadLine();
            int guess = int.Parse(guessInput);
            // Determine if the guess is too high or too low and prompt the user accordingly
            if (guess > magic)
            {
                Console.WriteLine($"{guess} is too high. Guess lower next time!");
            }

            else if (guess < magic)
            {
                Console.WriteLine($"{guess} is too low. Guess higher next time!");
            }

            else
            {
                Console.WriteLine($"The magic number was {magic} and you guessed {guess}. You Guessed it!");
                isCorrect = true;
            }
        }while (isCorrect == false);

    }


    static void Main_3(string[] args)
    {
        // CORE REQUIREMENT 3 - RANDOMLY GENERATE A NUMBER USED AS THE MAGIC NUMBER.
        
        // get a random number from 1 to 100
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 101);

        // explain the game to the User
        Console.WriteLine("Welcome! I have generated a random integer between 1 and 100 inclusive. Try to guess it!");
        

        // interaction loop
         // Loop through Logic
        // declare and initialize comparison variable
        bool isCorrect = false;

        do
        {

             // prompt the user for a guess
            Console.Write("Please Enter a Guess: ");
            string guessInput = Console.ReadLine();
            int guess = int.Parse(guessInput);
            // Determine if the guess is too high or too low and prompt the user accordingly
            if (guess > magic)
            {
                Console.WriteLine($"{guess} is too high. Guess lower next time!");
            }

            else if (guess < magic)
            {
                Console.WriteLine($"{guess} is too low. Guess higher next time!");
            }

            else
            {
                Console.WriteLine($"The magic number was {magic} and you guessed {guess}. You Guessed it!");
                isCorrect = true;
            }
        }while (isCorrect == false);



    }



    static void Main(string[] args)
    {
        // STRETCH CHALLENGES - KEEP TRACK OF THE NUMBER OF GUESSES AND INFORM THE USER OF IT AT THE END OF THE GAME. THEN ASK IF THEY WANT TO PLAY THE GAME AGAIN.

        // declare and initialize a playAgain string
        string playAgain = "yes";

        // loop through the game so long as playAgain is equal to yes
        do
        {
              // initialize a guess tracker
            int guessNum = 0;

            // get a random number from 1 to 100
            Random randomGenerator = new Random();
            int magic = randomGenerator.Next(1, 101);

            // explain the game to the User
            Console.WriteLine("Welcome! I have generated a random integer from 1 through 100. Try to guess it!");
            

            // interaction loop
            // Loop through Logic
            // declare and initialize comparison variable
            bool isCorrect = false;

            do
            {
                // add 1 to the guess count
                guessNum +=1;

                // prompt the user for a guess
                Console.Write("Please Enter a Guess: ");
                string guessInput = Console.ReadLine();
                int guess = int.Parse(guessInput);
                // Determine if the guess is too high or too low and prompt the user accordingly
                if (guess > magic)
                {
                    Console.WriteLine($"{guess} is too high. Guess lower next time!");
                }

                else if (guess < magic)
                {
                    Console.WriteLine($"{guess} is too low. Guess higher next time!");
                }

                else
                {
                    Console.WriteLine($"The magic number was {magic} and you guessed {guess}. It took you {guessNum} guesses");
                    isCorrect = true;
                }

                

            }while (isCorrect == false);

            // ask the user if they want to play again
            Console.Write("Would you like to play again?: ");
            playAgain = Console.ReadLine().ToLower();



        }while (playAgain == "yes");

        Console.WriteLine("Thanks for playing!");


       
    }
}

