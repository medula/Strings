//You are given a text. Write a program that changes the text in all regions
//surrounded by the tags <upcase> and </upcase> to uppercase. The tags cannot be nested.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ChangeToUpper
{
    static void Main()
    {
        string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        StringBuilder result = new StringBuilder();
        int index = 0;
        int indexNextOpeningTag = text.IndexOf('<'); //searching text before first '<', to copy all text before it
        while (indexNextOpeningTag != -1)
        {
            result = CopyText(text, result, index, indexNextOpeningTag);
            int indexNextClosingTag = text.IndexOf('>', indexNextOpeningTag + 1);
            indexNextOpeningTag = text.IndexOf('<', indexNextClosingTag + 1); //searching substring before next '<', to convert it to Uppercase
            result = ConvertTextToUpper(text, result, indexNextClosingTag, indexNextOpeningTag);
            indexNextClosingTag = text.IndexOf('>', indexNextOpeningTag + 1);
            index = indexNextClosingTag + 1;
            indexNextOpeningTag = text.IndexOf('<', indexNextClosingTag + 1);
            if (indexNextClosingTag == text.LastIndexOf('>'))
            {
                result = CopyText(text, result, indexNextClosingTag + 1, text.Length);
            }
        }

        Console.WriteLine(result);
    }
    static StringBuilder CopyText(string text, StringBuilder result, int startIndex, int endIndex)
    {

        for (int i = startIndex; i < endIndex; i++)
        {
            result.Append(text[i]);
        }
        return result;
    }
    static StringBuilder ConvertTextToUpper(string text, StringBuilder result, int startIndex, int endIndex)
    {
        string subStr = text.Substring(startIndex + 1, endIndex - startIndex - 1);
        string modifiedSubStr = subStr.ToUpper();
        result.Append(modifiedSubStr);
        return result;
    }
}





