using PlayerLog.MvcApp.DAL;
using PlayerLog.MvcApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PlayerLog.MvcApp.Areas.admin.Controllers
{
    public class adminController : Controller
    {
        // GET: admin/admin
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection fc)
        {
            if (fc["txtAd"] == "admin" && fc["txtPass"] == "admin32")
            {
                string pass = fc["txtPass"];
                Session["Pass"] = pass;
                return RedirectToAction("main");

            }
            return View();
        }

        public ActionResult main()
        {
            if (Session["Pass"]==null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return Redirect("/Kullanici/Index");
            }

            return View();
        }

    }
}