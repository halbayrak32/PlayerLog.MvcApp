using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PlayerLog.MvcApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.isim = "Ahmet";
            ViewData["ad"] = "Mehmet";
            
            return View();
        }

        


    }


}