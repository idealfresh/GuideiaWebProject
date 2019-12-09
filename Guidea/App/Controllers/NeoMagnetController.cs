using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class NeoMagnetController : Controller
    {
        public IActionResult Magnet()
        {
            return View();
        }
        public IActionResult MagneticBall()
        {
            return View();
        }
    }
}