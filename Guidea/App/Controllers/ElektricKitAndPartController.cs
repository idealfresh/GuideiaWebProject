using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class ElektricKitAndPartController : Controller
    {
        public IActionResult FrontKit()
        {
            return View();
        }
        public IActionResult RearKit()
        {
            return View();
        }
        public IActionResult MiddleKit()
        {
            return View();
        }
    }
}