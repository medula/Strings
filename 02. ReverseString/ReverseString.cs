//Write a program that reads a string, reverses it and prints the result at the console.
//Example: "sample"  "elpmas".
using System;
using System.Text;

    class ReverseString
    {
        static void Main()
        {
            string text = Console.ReadLine();
            char[] textOfChars = text.ToCharArray(); 
            StringBuilder reversedText= new StringBuilder();
            int index = (textOfChars.Length-1);
            while (index>=0)
            {
                 reversedText.Append(textOfChars[index]);
                 index--;
            }
            Console.WriteLine(reversedText.ToString());
        }
    }

