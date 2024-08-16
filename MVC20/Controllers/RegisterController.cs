using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC20.Models;

namespace MVC20.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult rege()
        {
            return View();
        }
        [HttpPost]
        public ActionResult rege(register reg)
        {
            if(ModelState.IsValid)
            {
                Repository1 rp1 = new Repository1();
                rp1.Reg(reg);
            }
            return RedirectToAction("show");
        }
        public ActionResult show()
        {
            return View();
        }
    }
}