//Write a program that encodes and decodes a string using given encryption key (cipher).
//The key consists of a sequence of characters. The encoding/decoding is done by performing 
//XOR (exclusive or) operation over the first letter of the string with the first of the key, 
//the second – with the second, etc. When the last key character is reached, the next is the first.

using System;
using System.Text;

    class Cipher
    {
        static void Main()
        {
            string cipher = "Lao Tzu";
            string text = "When I let go of what I am, I become what I might be.";
            Console.WriteLine("Initial text : "+ text);
            StringBuilder result = Encrypt(text, cipher);
            Console.WriteLine("Encrypted text : {0}", result);
            result = Decrypt(result, cipher);
            Console.WriteLine("Decrypted text : {0}", result);
        }
        static StringBuilder Encrypt(string text,string cipher)
        {
            StringBuilder result = new StringBuilder();
            for (int index = 0; index < text.Length; index++)
            {
                char letter = (text[index]);
                char cipherIndex = cipher[index % cipher.Length];
                result.Append((char)((letter) ^ (cipherIndex)));
            }
            return result;
        }
        static StringBuilder Decrypt(StringBuilder result, string cipher)
        {
            StringBuilder decrypredResult = new StringBuilder();
            for (int index = 0; index < result.Length; index++)
            {
                char letter = (result[index]);
                char cipherIndex = cipher[index % cipher.Length];
                decrypredResult.Append((char)((letter) ^ (cipherIndex)));
            }
            return decrypredResult;
        }
    }

