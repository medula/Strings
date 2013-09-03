//Write a program that reads a string from the console and prints all different letters in the string 
//along with information how many times each letter is found. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class DifferentLettersInString
{
    static void Main()
    {
        Console.WriteLine("Please enter a text: ");
        //string text = "aadjjfldfldlfldllllldlldllaooerwiere";
        string text = Console.ReadLine();
        char[] letters = new char[text.Length];
        for (int i = 0; i < text.Length; i++)
        {
            letters[i] = text[i];
        }
        int[] charArray = new int[65536];
        for (int i = 0; i < 65536; i++)
        {
            charArray[i] = 0;
        }
        for (int index = 0; index < letters.Length; index++)
        {
            int indexCharArray = letters[index];
            charArray[indexCharArray] += 1;
        }
        for (int j = 0; j < 65536; j++)
        {
            if (charArray[j] != 0)
            {
                char symbol = (char)j;
                Console.WriteLine("Character {0} is {1} time/s met in text", symbol, charArray[j]);
            }
        }
    }
}

