using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using SampleSite.Models;

namespace SampleSite.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Auth form)
        {
            if (!ModelState.IsValid)
                return View(form);
            FormsAuthentication.SetAuthCookie(form.Username, true);
            return RedirectToRoute("admin_default");
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToRoute("logout");
        }
    }
}