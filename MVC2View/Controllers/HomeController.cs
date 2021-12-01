using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC2View.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index()
        {
            if (false)
            {

            return View();
            }
            return Json(new { name = "Hello", surname = "World" });
        }
        
    }
}
