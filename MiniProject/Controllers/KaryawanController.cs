using MiniProject.DataAccess;
using MiniProject.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiniProject.Controllers
{
    public class KaryawanController : Controller
    {
        // GET: Karyawan
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List()
        {
            return View(KaryawanDataAccess.GetAll());
        }
        public ActionResult CreateEdit(KaryawanViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (KaryawanDataAccess.Update(model))
                    {
                        return Json(new { success = true, message = "Succes" }, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        return Json(new { success = false, message = KaryawanDataAccess.Message }, JsonRequestBehavior.AllowGet);
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
        public ActionResult Create(KaryawanViewModel model)
        {
            return CreateEdit(model);
        }
        public ActionResult Edit(int id)
        {
            return View(KaryawanDataAccess.GetById(id));
        }

        [HttpPost]
        public ActionResult Edit(KaryawanViewModel model)
        {
            return CreateEdit(model);
        }
        public ActionResult Delete(int id)
        {
            return View(KaryawanDataAccess.GetById(id));
        }
        //post delete
        [HttpPost]
        public ActionResult DeleteConfirm(int id)
        {
            if (KaryawanDataAccess.Delete(id))
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