//Write a program that finds how many times a substring is contained in a given text 
//(perform case insensitive search).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CountsSubstring
{
    static void Main()
    {
        string text = "We are living in an yellow submarine.We don't have anything else.Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        text = text.ToLower();
        string subStr = "in";
        int count = CountSubstringinText(text, subStr);
        Console.WriteLine("{0}", count);
    }
    static int CountSubstringinText(string text, string subStr)
    {
        int count = 0;
        int index = 0;
        index = text.IndexOf(subStr);
        while (index != -1)
        {
            count++;
            index = text.IndexOf(subStr, index + 1);
        }
        return count;
    }
}

