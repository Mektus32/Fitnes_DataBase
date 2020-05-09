using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fitnes.Controllers
{
    public class AuthorController : Controller {
        /*try {

        } catch (ArgumentNullExeption) {

        }*/

        public IActionResult Index()
        {
            return View();
        }
    }
}