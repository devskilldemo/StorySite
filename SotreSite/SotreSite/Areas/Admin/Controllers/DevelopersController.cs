using SotreSite.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SotreSite.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class DevelopersController : Controller
    {
        // GET: Admin/Developers
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add()
        {
            var model = new DeveloperModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Add(DeveloperModel model)
        {
            return View(model);
        }
    }
}