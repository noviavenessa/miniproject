using MiniProject.DataAccess;
using MiniProject.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiniProject.Controllers
{
    public class PelangganController : Controller
    {
        // GET: Kostumer
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List()
        {
            return View(PelangganDataAccess.GetAll());
        }
        public ActionResult CreateEdit(PelangganViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (PelangganDataAccess.Update(model))
                    {
                        return Json(new { success = true, message = "Succes" }, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        return Json(new { success = false, message = PelangganDataAccess.Message }, JsonRequestBehavior.AllowGet);
                    }
                }
                else
                {
                    return Json(new { success = false, message = "Pelase full fill required fields" }, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message }, JsonRequestBehavior.AllowGet);
                {

                }

            }

        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(PelangganViewModel model)
        {
            return CreateEdit(model);
        }
        public ActionResult Edit(int id)
        {
            return View(PelangganDataAccess.GetById(id));
        }

        [HttpPost]
        public ActionResult Edit(PelangganViewModel model)
        {
            return CreateEdit(model);
        }
        public ActionResult Delete(int id)
        {
            return View(PelangganDataAccess.GetById(id));
        }
        //post delete
        [HttpPost]
        public ActionResult DeleteConfirm(int id)
        {
            if (PelangganDataAccess.Delete(id))
            {
                return Json(new { success = true, message = "Success" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { success = false, message = "Error" }, JsonRequestBehavior.AllowGet);
            }
        }

    }
}