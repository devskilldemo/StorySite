using Ninject;
using SotreSite.Areas.Admin.Models;
using StorySite.Data;
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
        private IStorySiteUnitOfWork unitOfWork;
        public DevelopersController(IStorySiteUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        // GET: Admin/Developers
        public ActionResult Index()
        {
            var model = new DeveloperModel(this.unitOfWork);
            return View(model);
        }

        public ActionResult Add()
        {
            var model = new DeveloperModel(this.unitOfWork);
            return View(model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Add(DeveloperModel model)
        {
            if(ModelState.IsValid)
            {
                model.SetUnitOfWork(unitOfWork);
                model.CreateDeveloper();
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public JsonResult Delete(Guid id)
        {
            var model = new DeveloperModel(this.unitOfWork);
            if (model.Delete(id))
            {
                Session["Alert"] = "Developer Deleted!";
                return Json("success");
            }
            else
                return Json("fail");
        }

        public ActionResult Edit(Guid id)
        {
            var model = new DeveloperModel(this.unitOfWork);
            model.LoadData(id);
            return View(model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Edit(DeveloperModel model)
        {
            if (ModelState.IsValid)
            {
                model.SetUnitOfWork(unitOfWork);
                model.Edit();
            }
            return RedirectToAction("Index");
        }
    }
}