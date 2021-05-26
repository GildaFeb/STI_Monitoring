

using STI_Monitoring.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace STI_Monitoring.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Security()
        {
            return View();
        }
        // CAHSIER
        public ActionResult CashierMenu()
        {
            return View();
        }
    

        [HttpGet]
        public ActionResult RequestMonitoring()
        {
            GuestDBHandle dbhandle = new GuestDBHandle();
            ModelState.Clear();
            return View(dbhandle.GetRequest());
        }


        // GET: Monitoring/Details/5
        [HttpGet]
        public ActionResult GuestTransactions()
        {
            GuestDBHandle dbhandle = new GuestDBHandle();
            ModelState.Clear();
            return View(dbhandle.GetGuestTransaction());
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Napproved()
        {
            return View();
        }
        public ActionResult Grequest()
        {
            return View();


        }
    }
}