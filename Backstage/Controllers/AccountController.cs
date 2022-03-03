using Backstage.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backstage.Controllers
{
    public class AccountController : Controller
    {
        
        BackstageContext db = new BackstageContext();
        //public IActionResult Index()
        //{
        //    return View();
        //}


        [HttpGet]
        [Route("Account/Login")]
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        [Route("Account/Login")]
        public ActionResult Login(Users log)
        {
            var users = db.Users.Where(x => x.Username == log.Username && x.Password == log.Password).Count();
            if (users > 0)
            {
                return RedirectToAction("Home","Home");
            }
            else
            {
                return View();
            }
        }
        //[HttpGet]
        //[Route("Account/Dashboard")]
        //public ActionResult Dashboard()
        //{
        //    return View();
        //}
    }
}
