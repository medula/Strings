//Write a program that reads a string from the console and replaces all series of 
//consecutive identical letters with a single one. Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SeriesConsecutiveIdenticalLatters
{
    static void Main()
    {
        string text = "aaaaabbbbbcdddeeeedssaa";
        char letter = text[0];
        StringBuilder result = new StringBuilder();
        result.Append(letter);
        for (int index = 1; index < text.Length; index++)
        {
            char nextLetter = text[index];
            if (letter != nextLetter)
            {
                result.Append(nextLetter);
                letter = nextLetter;
            }
        }
        Console.WriteLine("{0}", result);
    }
}

