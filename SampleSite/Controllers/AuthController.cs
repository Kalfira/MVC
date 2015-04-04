using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
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
            FormsAuthentication.SetAuthCookie(form.Username, true);
            return View(form);
        }
    }
}