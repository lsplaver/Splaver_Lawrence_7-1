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
            ViewBag.Phone = "555-123-4567";
            ViewBag.Email = "me@mywebsite.com";
            ViewBag.Facebook = "facebook.com/mywebsite";
            return View();
        }

        [Route("/[controller]/[action]")]
        public IActionResult About()
        {
            ViewBag.About = "This is the basic version of a multi-page web app that uses multiple views, nested layouts, layout sections and a Help area";
            return View();
        }
    }
}
