//We are given a string containing a list of forbidden words and a text containing some of these words. 
//Write a program that replaces the forbidden words with asterisks. Example:
//Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented 
//as a dynamic language in CLR.
//Words: "PHP, CLR, Microsoft"
//		The expected result:
//********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 
//and is implemented as a dynamic language in ***.

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

class ForbiddenWords
{
    static void Main()
    {
        string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        string[] forbiddenWordsArray = { "PHP", "CLR", "Microsoft" };
        string modifiedText = text;
       
        for (int index = 0; index < forbiddenWordsArray.Length; index++)
        {
            MatchEvaluator myEvaluator = new MatchEvaluator(PrintAsterisks);
            modifiedText = Regex.Replace(modifiedText, @"\b" + forbiddenWordsArray[index] + @"\b", myEvaluator);   
        }
        Console.WriteLine("Original text: {0}", text);
        Console.WriteLine("Modified text : {0}",modifiedText);
        
    }
    static string PrintAsterisks(Match forbiddenWord)
    {
        string modifiedWord = "";
        for (int i = 0; i < forbiddenWord.Length; i++)
        {
            modifiedWord+='*';
        }
        modifiedWord.ToString();
        return modifiedWord;
    }
    

}

