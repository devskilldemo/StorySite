using log4net;
using log4net.Config;
using SotreSite.Models;
using StorySite.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SotreSite.Controllers
{
    public class HomeController : Controller
    {
        IStoryModel _model;
        public HomeController(IStoryModel model)
        {
            _model = model;
        }

        public ActionResult Index()
        {
            _model.CreateStory("Test", "test");

            return View();
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