using log4net;
using log4net.Config;
using SotreSite.Models;
using StorySite.Data;
using StorySite.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SotreSite.Controllers
{
    public class HomeController : Controller
    {
        IStoryModel mode;
        public HomeController(IStoryModel mode)
        {
            this.mode = mode;
        }

        public ActionResult Index()
        {
            mode.CreateStory("hello", "test");
            return View(mode);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}