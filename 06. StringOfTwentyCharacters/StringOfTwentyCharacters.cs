//Write a program that reads from the console a string of maximum 20 characters. 
//If the length of the string is less than 20, the rest of the characters should be filled with '*'.
//Print the result string into the console.

using System;
using System.Text.RegularExpressions;

    class StringOfTwentyCharacters
    {
        static void Main()
        {
            Console.WriteLine("Enter string of maximum 20 characters: ");
            string text = Console.ReadLine();
            Console.WriteLine(text.PadRight(20,'*'));
            
        }
    }

