using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Server.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            string a= Request.Form["swiper"];
            a = "fafsafasdfa";
            return View();
        }

        public ActionResult Login(string queren)
        {
            if (queren == "确认")
            {

            }
            return View();
        }

    }
}
