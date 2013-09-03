//Write a program for extracting all email addresses from given text. 
//All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.

using System;
using System.Text.RegularExpressions;

class IdentifyEmailAddresses
{
    static void Main()
    {
        string text = "litke@talktalk.net  owarne000s@talk21.com  seo@webindustry.co.uk  w0lfspirit32@hotmail.co.uk  robert.douglas3@virgin.net  dan@webindustry.co.uk  sasha_aitken@mail.ru Please contact us by phone (+359 222 222 222) or by email at exa_mple@abv.bg or at baj.ivan@yahoo.co.uk. This is not email: test@test. This also: @telerik.com. Neither this: a@a.b.";
        foreach (var item in Regex.Matches(text, @"[\w.]{2,20}@[\w]{2,20}[.]{1}[\w.]{2,6}"))
        {
        Console.WriteLine(item);
        }
    }
}

