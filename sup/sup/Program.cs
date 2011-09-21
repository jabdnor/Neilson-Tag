using System;
using System.IO;

namespace csharp_station.howto
{
    class TextFileWriter
    {
        static void Main(string[] args)
        {
            // create a writer and open the file
            TextWriter tw = new StreamWriter(@"C:\Users\Joe\Desktop\Test.xml");

            Console.WriteLine("Enter Website name");
            string web = Console.ReadLine();

            Console.WriteLine("Was the finding a success");
            string suc = Console.ReadLine();


            // write a line of text to the file
            tw.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
            tw.WriteLine("<Test>");
            tw.WriteLine("  <website> " + web + " </website>");
            tw.WriteLine("  <success> " + suc + " </success>");
            tw.WriteLine("</Test>");

            // close the stream
            tw.Close();
        }
    }
}