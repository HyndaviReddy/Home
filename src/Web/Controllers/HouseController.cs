using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class HouseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Apartment()
        {
           return Content("This is an Apartment, in text format");
        }
        public IActionResult Independent()
        {
            return Json(new { name = "Json", description = "Welcome to Independent house in house controller, in Json format"});
        }
          public IActionResult Villa()
        {
            return Content("<html> <body> <h1> This is a Villa </h1> </body> </html>","text/html");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}