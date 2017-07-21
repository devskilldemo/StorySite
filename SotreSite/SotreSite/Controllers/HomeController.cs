using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SotreSite.Controllers
{
    public class HomeController : Controller
    {
        private static readonly ILog log = LogManager.GetLogger("DemoLog");

        public ActionResult Index()
        {
            try
            {
                int x = 100000;
                for(int i = 10; i>= -10; i--)
                {
                    x = x / i;
                }
            }
            catch(Exception ex)
            {
                log.Debug("Errro in Index", ex);
            }
            
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