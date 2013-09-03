//Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> 
//with corresponding tags [URL=…]…/URL]. 
//<p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course.
//Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>
//Result example:
//<p>Please visit [URL=http://academy.telerik.com]our site[/URL] to choose a training course. 
//Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>

using System;
using System.Text.RegularExpressions;

    class ReplacingTagsInHTMLDoc
    {
        static void Main()
        {
            string text="<p>Please visit <a href=\"http://academy.telerik. com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
            string replacedOpeningBracket = Regex.Replace(text, "<a href=\"", "[URL=");
            string replacedClosingBracket = Regex.Replace(replacedOpeningBracket, "\">", "]");
            string replacedClosingTag = Regex.Replace(replacedClosingBracket, "</a>", "[/URL]");
            Console.WriteLine(replacedClosingTag);
        }
    }

