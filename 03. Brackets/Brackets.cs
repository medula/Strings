//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d).
//Example of incorrect expression: )(a+b)).

using System;
using System.Collections.Generic;
using System.Text;

class Brackets
{
    static void Main()
    {
        string expression = ")(a+b))";
        char[] formula = expression.ToCharArray();
        int numberOfBrackets = CountBrackets(formula);
        bool correctExpression = false;
        if (numberOfBrackets == 0)
        {
            correctExpression = true;
        }
        Console.WriteLine("Is expression {0} correct?   - {1}", expression, correctExpression);
    }
    static int CountBrackets(char[] formula)
    {
        int count = 0;
        for (int index = 0; index < formula.Length; index++)
        {
            if (formula[index] == '(')
            {
                count++;
            }
            else if (formula[index] == ')')
            {
                count--;
            }
        }
        return count;
    }
}

