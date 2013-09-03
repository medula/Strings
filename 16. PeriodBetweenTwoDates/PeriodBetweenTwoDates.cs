//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
//Example:
//Enter the first date: 27.02.2006
//Enter the second date: 3.03.2004
//Distance: 4 days

using System;
using System.Text;

class PeriodBetweenTwoDates
{
    static void Main()
    {
        Console.WriteLine("Enter the first date in format: day.month.year:");
        string firstDateText = Console.ReadLine();
        DateTime dateOne = ConvertDateToDateTime(firstDateText);
        Console.WriteLine("Enter the second date in format: day.month.year:");
        string secondDateText = Console.ReadLine();
        DateTime dateTwo = ConvertDateToDateTime(secondDateText);
        TimeSpan ts = dateTwo - dateOne;
        int differenceInDays = ts.Days;
        Console.WriteLine("Difference in days: {0} ", differenceInDays);
    }
    static DateTime ConvertDateToDateTime(string dateString)
    {
        string[] dateNumbers = dateString.Split('.');
        int d = int.Parse(dateNumbers[0]);
        int MM = int.Parse(dateNumbers[1]);
        int yyyy = int.Parse(dateNumbers[2]);
        DateTime date = new DateTime(yyyy, MM, d);
        return date;
    }

}

