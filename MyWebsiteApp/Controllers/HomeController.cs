using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsiteApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("/[controller]/[action]")]
        public IActionResult Contact()
        {
            var contaactInfo = new List<string> { "555-123-4567", "mywebsite.com", "facebook.com/mywebsite" };
            return View("Contact", contaactInfo);
        }

        [Route("/[controller]/[action]")]
        public IActionResult About()
        {
            ViewBag.About = "This is the basic version of a multi-page web app that uses multiple views, nested layouts, layout sections and a Help area";
            return View();
        }
    }
}
