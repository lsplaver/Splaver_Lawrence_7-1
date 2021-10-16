using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsiteApp.Areas.Help.Controllers
{
    [Area("Help")]
    public class TutorialController : Controller
    {
        [Route("/[area]/[controller]/[action]/Page{id}")]
        public IActionResult Index(int id)
        {
            if (id == 1)
            {
                return View("Page1");
            }
            else if (id == 2)
            {
                return View("Page2");
            }
            else if (id == 3)
            {
                return View("Page3");
            }    
            else
            {
                return Content("Invalid entry");
            }
        }
    }
}
