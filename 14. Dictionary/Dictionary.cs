//A dictionary is stored as a sequence of text lines containing words and their explanations. 
//Write a program that enters a word and translates it by using the dictionary. Sample dictionary:
//.NET – platform for applications from Microsoft
//CLR – managed execution environment for .NET
//namespace – hierarchical organization of classes

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Dictionary
{
    static void Main()
    {
        string[] dictionary = {".NET – platform for applications from Microsoft",
                                   "CLR – managed execution environment for .NET",
                                   "namespace – hierarchical organization of classes"};
        string wordToTranslate = Console.ReadLine();
        for (int index = 0; index < dictionary.Length; index++)
        {
            int indexDash = dictionary[index].IndexOf('–');
            string subStr = dictionary[index].Substring(0, indexDash - 1);
            if (Equals(wordToTranslate, subStr))
            {
                string result = dictionary[index].Substring(indexDash + 2, dictionary[index].Length - indexDash - 2);
                Console.WriteLine(result);
                return;
            }
        }
        Console.WriteLine("Word is not contained in dictionary.");

    }
}

