﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//messing with git
namespace HangmanFun
{
    internal class HangmanTools
    {
        public string GetRandomWord()
        {
            Random r = new Random();

            string word = "";

            List<string> words = new List<string>()
            {
                "hello" ,
                "customer",
                "synthetic", 
                "leach", 
                "laugh"

            };

            //list a random word
            word = words[r.Next(words.Count)];

            return word;

        }

        public bool ValidGuess(string guess, string lettersGuessed)
        {
            bool result = true; //default to a valid guess

            if(guess.Length != 1) //check for only one character
            {
                Console.WriteLine("Sorry, the guess can only be one letter. Try again.");
                result = false;
            }
            else if (!Char.IsLetter(guess[0])) //check to make sure it is a letter
            {
                Console.WriteLine("Sorry, the guess needs to be a letter. Try again");
                result = false;
            }
            else if (lettersGuessed.Contains(guess)) //check to see if the letter has already been guessed
            {
                Console.WriteLine("Sorry, you already guessed that letter. Try again");
                result = false;
            }

            return result;

        }
        public string UpdateWord(string lettersGuessed, string solution)
        {
            string result = "";

            for (int i = 0; i < solution.Length; i++)
            {
                if (lettersGuessed.Contains(solution[i]))// Is the letter in the list already 
                {
                    result += solution[i];
                }
                else
                {
                    result += "_";
                }
            }
            return result;
        }
    }
}
