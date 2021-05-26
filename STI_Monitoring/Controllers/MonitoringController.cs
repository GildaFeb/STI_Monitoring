using STI_Monitoring.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace STI_Monitoring.Controllers
{
    public class MonitoringController : Controller
    {
        // GET: Monitoring
       

        [HttpGet]
        public ActionResult GetGuest()
        {
            GuestDBHandle dbhandle = new GuestDBHandle();
            ModelState.Clear();
            return View(dbhandle.GetAllGuest());
        }



        [HttpGet]
        public ActionResult Cashier()
        {
            GuestDBHandle dbhandle = new GuestDBHandle();
            ModelState.Clear();
            return View(dbhandle.GetCashier());
        }


        // POST: Monitoring/Create
        public JsonResult EditRequest(int ID)
        {
            GuestDBHandle guestDB = new GuestDBHandle();
            var Guest = guestDB.GetRequest().Find(x => x.VisitLogID.Equals(ID));
            return Json(Guest, JsonRequestBehavior.AllowGet);
        }

        // GET: Monitoring/Edit/5

        // GET: Monitoring/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Monitoring/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Ind");
            }
            catch
            {
                return View();
            }
        }
    }
}
