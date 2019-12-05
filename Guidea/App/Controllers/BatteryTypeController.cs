using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class BatteryTypeController : Controller
    {
        public IActionResult BatteryCell()
        {
            return View();
        }
        public IActionResult BatteryPack()
        {
            return View();
        }
        public IActionResult BatteryRepair()
        {
            return View();
        }
    }
}