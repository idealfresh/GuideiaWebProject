using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class BickeControllerAndDisplayController : Controller
    {
        public IActionResult BickeController()
        {
            return View();
        }
        public IActionResult BickeDisplay()
        {
            return View();
        }
    }
}