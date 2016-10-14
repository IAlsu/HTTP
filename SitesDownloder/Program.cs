using System;
using LinksSearch;

namespace SitesDownloder
{
    class Program
    {
        enum resourseExtentions { gif, jpeg, jpg, pdf, html };
        public static void Main(string[] args)
        {
            //const int depthRestriction = 5;

            //Console.WriteLine("Enter the URL: ");
            //string url = Console.ReadLine();

            //Console.WriteLine("Enter the path (location on your PC): ");
            //string path = Console.ReadLine();

            //Console.WriteLine("Select the type of domain restriction: ");
            //Console.WriteLine("No restrictions - 1");
            //Console.WriteLine("In current domain only - 2");
            //Console.WriteLine("Lower than initial URL - 3");
            //string domainRestriction = Console.ReadLine();

            Links website = new Links("http://stackoverflow.com/", @"C:\");
            var listOfLinks = website.GetLinksFromWebsite();

            Console.ReadLine();
        }
    }
}
