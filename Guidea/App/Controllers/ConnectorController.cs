using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class ConnectorController : Controller
    {
        public IActionResult XT90Connector()
        {
            return View();
        }
        public IActionResult XT60Connector()
        {
            return View();
        }
        public IActionResult TConnector()
        {
            return View();
        }
        public IActionResult BigTamiya()
        {
            return View();
        }

        public IActionResult DCWithFlap()
        {
            return View();
        }

        public IActionResult WaterproofModel1()
        {
            return View();
        }
        public IActionResult WaterproofModel2()
        {
            return View();
        }
        public IActionResult WaterproofModel3()
        {
            return View();
        }
        public IActionResult WaterproofModel4()
        {
            return View();
        }
        public IActionResult Gx16()
        {
            return View();
        }
    }
}