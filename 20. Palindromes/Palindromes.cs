//Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

class Palindromes
{
    static void Main()
        {
            string originalText="civic civil Dewed died deified dad mom devoved Hannah peeweep repaper kayak minim radar murdrum";
            string text = originalText.ToLower();
            string[] words=text.Split(' ');
            for (int index = 0; index < words.Length; index++)
            {
                bool isPalindrome=CheckIfPalindrome(words[index]);
               if(isPalindrome)
                {
                Console.WriteLine(words[index]);
                }
            }
        }
    static bool CheckIfPalindrome(string word)
    {
        int index = 0;
        bool result = false;
        int checkedLength = 0;
        if (word.Length % 2 == 0)
        {
            checkedLength = word.Length / 2;
        }
        else
        {
            checkedLength = (word.Length / 2);
        }
        while (index <= checkedLength)
        {
            if (word[index] == word[word.Length -1- index])
            {
                result = true;
            }
            else
            {
                result = false;
                return result;
            }
            index++;
        }
        return result;
    }
}

