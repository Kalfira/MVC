using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using SampleSite.Models;
using SampleSite.DAL;

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
            Session["User"] = form.Username;
            if (Validate.IsUser(form.Username, form.Password))
                {
                    Session["Role"] = "admin";
                    return RedirectToRoute("admin_default");
                }
            return View();

        }

        public ActionResult Logout()
        {
            Session["User"] = null;
            Session["Role"] = null;
            return RedirectToRoute("logout");
        }

        public ActionResult Forgot()
        {
            return Content("TOO BAD!");
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Auth form)
        {
            Validate.Register(form.Username, form.Password);
            return View();
        }
    }
}