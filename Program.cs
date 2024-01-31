//think of a word(get random word)

//get the guess from the player

//check to see if guess is valid (NAN, only one letter, hasn't been guessed before)

//Check to see if letter is in the word

//if it does, we need to update the word from the blanks to actual letters

//if it does not, we need to keep track of how many missed guesses(6 total wrong guesses)

//let them know if they won or lost

//game flow

//Team 1 (main)
// - game flow 
// - get guess 
// - Check to see if letter is in the word
// - Keep track of guesses
// - Let them know if they won or lost

//Team 2 (tools)
// - generate a random word 
// - validate the guess
// - Update the word

//Generate a random word
// - public string GetRandomWord();  <-- method signiture

//Validate the guess
// - public bool ValidGuess(string guess, string lettersGuessed) <-- method signiture

//Update the word
// - public string UpdateWord(string lettersGuessed, string solution)

using HangmanFun;

HangmanTools ht = new HangmanTools();

string solution = "";
string guess = "";
string lettersGuessed = "";
int incorrectGuesses = 0;

bool gameOver = false;

// Welcome the user
Console.WriteLine("Welcome to our hangman Game! I hope you enjoy!");
Console.Write("Generating a random word");
Thread.Sleep(500);
Console.Write(".");
Thread.Sleep(500);
Console.Write(".");
Thread.Sleep(500);
Console.Write(".");

solution = ht.GetRandomWord();

Console.WriteLine();

Console.WriteLine("Alright I have your word to guess");

do
{
    //Get the user's guess
    Console.WriteLine("Please enter a letter");

    //validate the guess
    do
    {
        guess = Console.ReadLine();

    } while (!ht.ValidGuess(guess, lettersGuessed));

    //update the list of letters guess 
    lettersGuessed += guess;

    //check to see if the letter is in the word

    if (solution.Contains(guess))
    {
        Console.WriteLine($"Yes, the letter {guess} is in the word!");
        
        if (ht.UpdateWord(lettersGuessed, solution) == solution)
        {
            Console.WriteLine("You won!");
            gameOver = true;
        }

        Console.WriteLine($"Word {ht.UpdateWord(lettersGuessed, solution)}");
    }
    else //if the guess was incorrect
    {
        Console.WriteLine($"Sorry, the word does not have the letter {guess} ");

        incorrectGuesses++;

        if (incorrectGuesses < 6)
        {
            Console.WriteLine($"You have {6 - incorrectGuesses} guesses left");
        }
        if (incorrectGuesses >=6)
        {
            Console.WriteLine("Sorry, you lost");
            Console.WriteLine($"The word was {solution}");
            gameOver = true;
        }

    }

    

} while (!gameOver);

Console.WriteLine("Thanks for playing");







