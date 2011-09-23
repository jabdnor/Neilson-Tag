using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;


namespace HeaderCatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            //String URI = WebFetch.PageSource("http://www.nielsen.com/us/en.html");
            CookieCollection URI_COOKIE = WebFetch.CookieInfo("http://www.nielsen.com/us/en.html");
            WebHeaderCollection URI_HEADER = WebFetch.HeaderInfo("http://www.nielsen.com/us/en.html");
            //Console.WriteLine(URI_COOKIE);
            //Console.WriteLine(URI_HEADER);
            Console.ReadLine();

        }
    }
}
