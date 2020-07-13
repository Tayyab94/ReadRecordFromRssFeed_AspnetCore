using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ReadRssFeedInAspnetCore.Helper;
using ReadRssFeedInAspnetCore.Models;

namespace ReadRssFeedInAspnetCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // string url = "http://feeds.reuters.com/news/artsculture?format=xml";

            // ViewBag.itemlist = RssHelper.Read(url);
            string url = "https://www.espncricinfo.com/rss/content/story/feeds/2.xml";
            var data = RssHelper.CricketRss(url);
            ViewBag.itemlist = RssHelper.CricketRss(url);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
