//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
using System;
using System.Collections.Generic;
using System.Text;

    class AlphabeticalOrderOfWords
    {
        static void Main()
        {
            string text="Run the example and you will see that it fails when \"q\" is the last letter of a word, as in \"Iraq\". "+
            "This is because \"[^q]\" always matches a character. If \"q\" is the last character of the word, it will match " +
            "the whitespace character that follows, so in the example the expression ends up matching two whole words.";
            string[] words = text.Split(' ');
            Array.Sort(words);
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
        }
    }

