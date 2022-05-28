using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.Controllers
{
    public class HomeController:Controller
    {
        public ContentResult Text()
        {
            var result = Content("Salamlar");
            return result;
        }
        public ViewResult Index() 
        {
            return View();
        }

        public ActionResult ShowId(int id) 
        {
            TempData["showId"] = id;
            ViewData["showId"] = id;
            ViewBag.showId = id;
            return View();
        }
    }
}
