//Write a program that reads a date and time given in the format: day.month.year hour:minute:second 
//and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.

using System;
using System.Text;
using System.Globalization;

class DateAndTimeInFormat
{
    static void Main()
    {
        Console.WriteLine("Enter date in format day.month.year hour:minute:second ");
        string inputDate = Console.ReadLine();
        DateTime dateOne = ConvertDateToDateTime(inputDate);
        DateTime newDateTime = dateOne.AddHours(6.5);
        System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("bg-BG"); ;
        string day = newDateTime.ToString("dddd");
        Console.WriteLine("Day and time after 6 hours and 30 minutes: {0:dd.MM.yyyy HH:mm:ss},{1}", newDateTime, day);
    }
    static DateTime ConvertDateToDateTime(string inputDate)
    {
        char[] delimiters = { '.', ':', ' ' };
        string[] dateNumbers = inputDate.Split(delimiters);
        int d = int.Parse(dateNumbers[0]);
        int MM = int.Parse(dateNumbers[1]);
        int yyyy = int.Parse(dateNumbers[2]);
        int hour = int.Parse(dateNumbers[3]);
        int minute = int.Parse(dateNumbers[4]);
        int seconds = int.Parse(dateNumbers[5]);
        DateTime date = new DateTime(yyyy, MM, d, hour, minute, seconds);
        return date;
    }
}

