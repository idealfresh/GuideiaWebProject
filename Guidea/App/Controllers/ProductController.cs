using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Battery()
        {
            return View();
        }

        public IActionResult Magnets()
        {
            return View();
        }
    }
}