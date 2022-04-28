Console.WriteLine("Welcome to the Random Number Guesser Application!");
CleanScreen();

bool guessingRandomNumbers = true;
while (guessingRandomNumbers)
{
    GuessNumbers();
    guessingRandomNumbers = WannaRestart();
}
Console.WriteLine("Thank you for using the Random Number Guesser Application!");
Console.WriteLine("Goodbye...");

static void CleanScreen()
{
    Console.WriteLine("");
    Console.WriteLine("Press Enter to Continue.");
    Console.ReadLine();
    Console.Clear();
}
static bool WannaRestart()
{
    bool askingUser = true;
    while (askingUser)
    {
        Console.WriteLine("Would you like to guess another random number?");
        Console.WriteLine("Enter 'YES' or 'Y' to restart, or nter 'NO' to end the program.");
        Console.WriteLine("");
        Console.Write("Your Choice: ");
        string userAnswer = Console.ReadLine().ToLower();
        if (userAnswer == "yes" || userAnswer == "y")
        {
            CleanScreen();
            return true;
        }
        else if (userAnswer == "no" || userAnswer == "n")
        {
            CleanScreen();
            return false;

        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine("I'm sorry, I didn't understand that choice. Let's try again.");
            Console.WriteLine("");
        }
    }
    return false;
}
static void GuessNumbers()
{
    Random random = new Random();
    int randomNumber = random.Next(1, 100);
    List<int> guesses = new List<int>();

    Console.WriteLine("I'm thinking of a random number between 1 and 100 inclusive - let's see if you can guess it!");

    bool guessingANumber = true;
    while (guessingANumber)
    {
        Console.Write("Enter a number as a guess: ");
        string userNumber = Console.ReadLine();
        bool isANumber = int.TryParse(userNumber, out int realNumber);
        if (isANumber)
        {
            if (realNumber <= 0 || realNumber >= 101)
            {
                guesses.Add(realNumber);
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Remember: the random number will be between 1 and 100 inclusive, friend. Let's try again.");
                Console.ResetColor();
                Console.WriteLine("");
            }
            else
            {
                if (realNumber > randomNumber+10)
                {
                    guesses.Add(realNumber);
                    Console.WriteLine("");
                    Console.WriteLine($"That number is way too high! Try again.");
                    Console.WriteLine("");
                }
                else if (realNumber > randomNumber)
                {
                    guesses.Add(realNumber);
                    Console.WriteLine("");
                    Console.WriteLine($"You're close, but that's too high! Try again.");
                    Console.WriteLine("");

                }
                else if (realNumber < randomNumber - 10)
                {
                    guesses.Add(realNumber);
                    Console.WriteLine("");
                    Console.WriteLine($"That number is way too low! Try again.");
                    Console.WriteLine("");

                }
                else if (realNumber < randomNumber)
                {
                    guesses.Add(realNumber);
                    Console.WriteLine("");
                    Console.WriteLine($"You're close, but that's too low! Try again.");
                    Console.WriteLine("");
                }
                else if (realNumber == randomNumber)
                {
                    guesses.Add(realNumber);
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Beep();
                    Console.WriteLine($"Nice work, you guessed it! The number was indeed {randomNumber}!");
                    Console.WriteLine($"It took {guesses.Count} tries to guess the random number this time.");
                    Console.ResetColor();
                    Console.WriteLine("");
                    guesses.Clear();
                    break;
                }

            }
        }
        else
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("I'm sorry, that doesn't appear to be a number. Let's try again.");
            Console.ResetColor();
            Console.WriteLine("");
        }
    }
}