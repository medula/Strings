//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. 
//Display them in the standard date format for Canada.

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Globalization;

class DateMatchingFormat
{
    static void Main()
    {
        string text = "31.12.2013 44.55.2000 333.23.12.   321.32.2 I was born on 14.06.1980. My sister was born on 03.07.1984. In 5/1999 I graduated my high school. The law says (see section 7.3.12) that we are allowed to do this (section 7.4.2.9).";
        DateTime date;
        foreach (Match item in Regex.Matches(text, @"((((0?[1-9])|[12][0-9]|3[01])\.((0?[13578])|(1[02])))|(((0?[1-9])|[12][0-9]|30)\.((0?[469])|11))|(((0?[1-9])|[12][0-9])\.(0?2)))\.\d{4}"))
        {
                    if (DateTime.TryParseExact(item.Value, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern));
                    }
    }
}
