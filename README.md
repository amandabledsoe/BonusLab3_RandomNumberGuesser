This my solution for Bonus Lab 3: Unit 2 in the 2022 C# .NET After-Hours Boot Camp at Grand Circus.

# BONUS-3: Random Number Guesser

### Task: 
Guess a number from 1 to 100. You should complete this by pair programming.
Yes, really. Buddy up, and close one of your computers.

### What will the application do?
- The application prompts the user for an int value from 1 to 100 until the user guesses the random number that the application has generated.
- The application displays messages that indicate whether the user’s guess is too high or too low.
- When the user finally guesses the number, the application displays the number of guesses it took the user along with a rating.
- The application prompts the user to play again.
- When the user chooses to end the game, the application displays a goodbye message.

### Build Specifications
- If the user’s guess is more than 10 higher or more than 10 lower than the random number, the user should be notified as such. (ex: “Way too high!”)
- If the user’s guess is less than 10 higher or less than 10 lower than the random number, then the user should be notified as such. (ex: “Too low!”)
- The message that’s displayed when the user successfully gets the number should change based on the number of guesses it took him or her.
- The application should only accept numbers from 1 to 100. 
- When the user is prompted to Play Again, the application should only accept a value of “y” or “n”.
- If the user enters invalid data, the application should display an error message and prompt the user for data again.
- The code used to validate the data should be stored in separate methods.

### Hints:
- Use the Random class to generate a random number.
- Hint for number 7:
- public static double GetDoubleWithinRange(string Prompt, double Min, double Max)
- public static int GetIntWithinRange(string Prompt, int Min, int Max)


### Console Preview: 
```
Welcome to the Guess a Number Game!
+++++++++++++++++++++++++++++++++

I’m thinking of a number between 1 and 100.
Try to guess it, n00b.

Enter your lousy guess: 8
You got it in 1 tries.
You must be seriously amazing slash telepathic! 

Try again? (y/n): y

I’m thinking of a number between 1 and 100.
Try to guess it, n00b.

Enter your lousy guess: 8
You’re crazy low, bro. Try again.

Enter a number: 49
Too low, Joe. Try again.

Enter a number: 56
Too high! Try again.

Enter a number: 51
You got it in 4 tries.
Pretty good, I guess. I bet you can do better, though.

Try again? (y/n): ….
```
