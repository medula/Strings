//Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings. 

using System;
using System.Text;

    class ConvertsStringToUnicodeChar
    {
        static void Main()
        {
            string text = "On my knees, I'll ask Last chance for one last dance.      Far Away by Nickelback";
            StringBuilder result = new StringBuilder();
            for (int index = 0; index < text.Length; index++)
            {
                ushort charToUshort = (ushort)text[index];
                string formattedChar = String.Format("\\u{0:x4}",charToUshort);
                result.Append(formattedChar);
            }
            Console.WriteLine("Original text: {0}", text);
            Console.WriteLine("Formatted text: {0}",result);
        }
    }

