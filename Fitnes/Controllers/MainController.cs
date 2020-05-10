using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fitnes.Controllers {
    public class Main : Controller
    {
        public ViewResult ErrorPage(string message, string call) {
            ViewBag.ErrorMessage = message;
            ViewBag.Call = call;
            return View();
        }
        public IActionResult MainPage()
        {
            return View();
        }
    }
}