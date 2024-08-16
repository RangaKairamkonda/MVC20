using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC20.Models;

namespace MVC20.Controllers
{
    public class loginCheckController : Controller
    {
        // GET: loginCheck
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult check()
        {
            return View();
        }

        [HttpPost]
        public ActionResult check(LoginModel obj)
        {
            if(ModelState.IsValid)
            {
                Repository rp = new Repository();
                if(rp.Check(obj.username,obj.password))
                {
                    return View("sucess", obj);
                }
                else
                {
                    ViewBag.Message = "invalid username or password";
                }
                return View();
            }
            else
            {
                return View();
            }
           
            
        }
        public ActionResult sucess()
        {
            return View();
        }


    }

}