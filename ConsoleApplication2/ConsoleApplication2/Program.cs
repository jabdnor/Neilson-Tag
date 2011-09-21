using System;

using System.Text;
using System.Net;
using System.IO;

namespace Scraper1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter URL: ");
            String URL = Console.ReadLine();

            WebRequest req = WebRequest.Create(URL);
            WebResponse resp = req.GetResponse();

            StreamReader reader =
                new StreamReader(resp.GetResponseStream(), Encoding.ASCII);

            String page = reader.ReadToEnd();
            Console.WriteLine(page);
            Console.ReadLine();
        }
    }
}
