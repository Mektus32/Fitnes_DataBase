using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fitnes.Controllers {
    public class Main : Controller
    {
        public ViewResult ErrorPage(string message, string call, string output = "Error!") {
            List<string> list = new List<string>() { message, call, "Show" + call + 's' , "Show " + call, output};
            return View(list);
        }
        public IActionResult MainPage()
        {
            return View();
        }
    }
}