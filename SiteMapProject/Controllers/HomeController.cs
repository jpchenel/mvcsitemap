using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiteMapProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Project()
        {
            return View();
        }

        public ActionResult Edit(int id)
        {
            ViewBag.ID = id;
            return View();
        }
    }
}