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
        public ActionResult Index(FormCollection fc)
        {
            if (fc["txtAd"] == "admin" && fc["txtPass"] == "admin")
            {
                RedirectToAction("main");

            }
            return View();
        }
    }
}