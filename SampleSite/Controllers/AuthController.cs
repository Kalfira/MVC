using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SampleSite.ViewModels;

namespace SampleSite.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        public ActionResult Index()
        {
            return View(new Auth
                {
                    Test ="This is my test value"
                });
        }

        public ActionResult Login()
        {
            return View(new Auth
                {
                    Test ="This is my test value"
                });
        }

        [HttpPost]
        public ActionResult Login(Auth form)
        {
            if (!ModelState.IsValid)
                return View(form);

           if(form.Username != "Zane Degner")
           {
               ModelState.AddModelError("Username", "Username isn't awesome");
               return View(form);
           }
            return View(form);
        }
    }
}