using ReadRssFeedInAspnetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using System.Xml.XPath;
namespace ReadRssFeedInAspnetCore.Helper
{
    public class RssHelper
    {
        public static List<Item> Read(string url)
        {
            List<Item> itemsList = new List<Item>();

            try
            {
                //XPathDocument doc = new XPathDocument("http://feeds.reuters.com/news/artsculture?format=xml");

                XPathDocument doc = new XPathDocument(url);

                XPathNavigator navigator = doc.CreateNavigator();

                XPathNodeIterator nodes = navigator.Select("//item");

                while (nodes.MoveNext())
                {
                    XPathNavigator node = nodes.Current;

                    itemsList.Add(new Item
                    {
                        Category = node.SelectSingleNode("Category").Value,
                        description = node.SelectSingleNode("description").Value,
                        guid = node.SelectSingleNode("guid").Value,
                        link = node.SelectSingleNode("link").Value,
                        Pubdate = node.SelectSingleNode("Pubdate").Value,
                        title = node.SelectSingleNode("title").Value
                    });
                }
            }
            catch (Exception)
            {
                itemsList = null;
            }

            return itemsList;
        }

        public static List<Cricket> CricketRss(string url)
        {
            List<Cricket> itemsList = new List<Cricket>();

            try
            {
                //XPathDocument doc = new XPathDocument("http://feeds.reuters.com/news/artsculture?format=xml");

                XPathDocument doc = new XPathDocument(url);

                XPathNavigator navigator = doc.CreateNavigator();

                XPathNodeIterator nodes = navigator.Select("//item");

                while (nodes.MoveNext())
                {
                    XPathNavigator node = nodes.Current;

                    itemsList.Add(new Cricket
                    {
                        coverImages = node.SelectSingleNode("coverImages").Value,
                        description = node.SelectSingleNode("description").Value,
                        guid = node.SelectSingleNode("guid").Value,
                        link = node.SelectSingleNode("link").Value,
                        pubDate = node.SelectSingleNode("pubDate").Value,
                        title = node.SelectSingleNode("title").Value
                    });
                }
            }
            catch (Exception)
            {
                itemsList = null;
            }

            return itemsList;
        }
    }
}
