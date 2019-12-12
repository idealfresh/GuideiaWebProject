using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class BatteryAccessoriesController : Controller
    {
        public IActionResult BatteryAccessories()
        {
            return View();
        }
    }
}