using Backstage.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backstage.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Home()
        {
            return View();
        }
        [HttpGet]
        [Route("Home/Dashboard")]
        public IActionResult Dashboard()
        {
            return View();
        }

        [HttpGet]
        public IActionResult EPG()
        {
            return View();

        }
        [HttpPost]
        public IActionResult EPG(SubscriptionPackages subscriptionPackages)
        {
            return View();
        }
    }
}
