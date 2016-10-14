using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using HtmlAgilityPack;

namespace LinksSearch
{
    public class Links
    {
        private string url;
        private string location;

        public Links(string url, string location)
        {
            this.url = url;
            this.location = location;
        }
        public List<string>  GetLinksFromWebsite()
        {
            var doc = new HtmlWeb().Load(url);
            var linkTags = doc.DocumentNode.Descendants("link");
            var linkedPages = doc.DocumentNode.Descendants("a")
                                              .Select(a => a.GetAttributeValue("href", null))
                                              .Where(u => !String.IsNullOrEmpty(u)).ToList();

            return linkedPages;
        }


        //public static List<String> GetContentFromWebsite(List<String> htmlSource)
        //{
        // 
        //}

        public static void  DownloadContentFromWebsite(List<String> htmlSource)
        {
            using (WebClient client = new WebClient()) // WebClient class inherits IDisposable
            {
                client.DownloadFile("http://yoursite.com/page.html", @"C:\localfile.html");

                //// Or you can get the file content without saving it:
                //string htmlCode = client.DownloadString("http://yoursite.com/page.html");
                ////...
            }
        }
    }
}
