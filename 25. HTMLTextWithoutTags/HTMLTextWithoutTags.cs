//Write a program that extracts from given HTML file its title (if available),
//and its body text without the HTML tags. Example:
//<html>
//<head><title>News</title></head>
//<body><p><a href="http://academy.telerik.com">Telerik
//Academy</a>aims to provide free real-world practical
//training for young people who want to turn into
//skillful .NET software engineers.</p></body>
//</html>
//Result:
//Title: News
//Body:
//Telerik Academy aims to provide free real-world practical training for young people who want to turn into skillful .NET software 
//engineers.
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

class HTMLTextWithoutTags
{
    static void Main()
    {
        string text = "<html><head><title>News</title></head><body><p><a href=\"http://academy.telerik.com\">Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into skillful .NET software engineers.</p></body></html>";
        StringBuilder result = new StringBuilder();
        string mode = "";
        int indexStartTitle = text.IndexOf("<title>");
        int indexEndTitle = text.IndexOf("</title>");
        string titleName = text.Substring(indexStartTitle+7, indexEndTitle - indexStartTitle-7);
        result.Append("Title: "+ titleName+"\n" +"Body: "+"\n");
        for (int index = indexEndTitle+1; index < text.Length; index++)
        {
                        if (text[index] == '<')
            {
                mode = "tag opened";
            }
            if (text[index] == '>')
            {
                mode = "tag closed";
                result.Append(" ");
            }
            if (mode == "tag closed" && text[index] != '>')
            {
                result.Append(text[index]);
            }
        }
        Console.WriteLine("{0}", result);
    }
}
//Сканирайте текста побуквено и във всеки един момент пазете в една променлива дали към момента има отворен таг,
//който не е бил затворен или не. Ако срещнете "<", влизайте в режим "отворен таг". Ако срещнете ">", 
//излизайте от режим "отворен таг". Ако срещнете
//буква, я добавяйте към резултата, само ако програмата не е в режим "отворен таг". 
//След затваряне на таг може да добавяте по един интервал, за да не се слепва текст преди и след тага.