using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC2View.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index(int? id)
        {
            if (id==null)
            {
                ViewBag.data = "Id is null";
                return View();

            }
            return Json(new { Name = "Jason", Surnam="Statham", Age = 50 });
            
        }
    }
}
