//Write a program that parses an URL address given in the format:
//and extracts from it the [protocol], [server] and [resource] elements. 
//For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
//	[protocol] = "http"
//	[server] = "www.devbg.org"
//	[resource] = "/forum/index.php"

using System;
using System.Text;

    class URLAddress
    {
        static void Main()
        {
            string url = "http://www.devbg.org/forum/index.php";
            int indexProtocol = url.IndexOf(':');
            string protocol = url.Substring(0, indexProtocol);
            int indexSrever = url.IndexOf('/', indexProtocol+3);
            string server = url.Substring(indexProtocol + 3, indexSrever - (indexProtocol + 3));
            string resource = url.Substring(indexSrever, url.Length - indexSrever);
            Console.WriteLine("[protocol] = \"{0}\"", protocol);
            Console.WriteLine("[server] = \"{0}\"", server);
            Console.WriteLine("[resource] = \"{0}\"", resource);
        }
    }

