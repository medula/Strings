//Write a program that extracts from a given text all sentences containing given word.
//Example: The word is "in". The text is:
//We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. 
//So we are drinking all the day. We will move out of it in 5 days.
//The expected result is:
//We are living in a yellow submarine.
//We will move out of it in 5 days.
//Consider that the sentences are separated by "." and the words – by non-letter symbols.

using System;
using System.Text;

class ExtractSentenceContainingGivenWord
{
    static void Main()
    {
        string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day.We will move out of it in 5 days.";
        string[] sentences = text.Split('.');
        string word = "in";
        StringBuilder result = new StringBuilder();
        for (int index = 0; index < sentences.Length; index++)
        {
            string sentence = sentences[index]; //separate sentence from text
            int indexWord = sentences[index].IndexOf(word);
            while (indexWord != -1)
            {
                bool previousChar = Char.IsLetter(sentence[indexWord - 1]);
                bool nextChar = Char.IsLetter(sentence[indexWord + 1]);
                if (!previousChar || !nextChar)
                {
                    result.Append(sentences[index]);
                    result.Append('.');
                    result.Append("\n");
                }
                indexWord = sentences[index].IndexOf(word, indexWord + 1);
            }
        }
        Console.WriteLine(result);
    }
}


