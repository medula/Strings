//Write a program that reverses the words in given sentence.

using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Threading.Tasks;

class ReversesWordsInSentence
{
    static void Main()
    {
        string sentence = "C# is not C++, not PHP and not Delphi!";
        string regex = @"\s+|,\s*|\.\s*|!\s*";
        List<string> delimiters = new List<string>();
        List<string> words = new List<string>();
        foreach (string word in Regex.Split(sentence, regex))
            words.Add(word);
        foreach (Match separator in Regex.Matches(sentence, regex))
            delimiters.Add(separator.Value);
        for (int i = 0; i < delimiters.Count; i++)
            Console.Write(words[words.Count - 2 - i] + delimiters[i]);
    }
}


