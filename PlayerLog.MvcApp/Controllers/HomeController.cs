using PlayerLog.MvcApp.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PlayerLog.MvcApp.Models;

namespace PlayerLog.MvcApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {                       
            return View();
        }
         
        [HttpPost]
        public ActionResult Index(FormCollection fc)
        {
            using (TakimContext ctx = new TakimContext())
            {
                string KullaniciAdi = fc["KullaniciAdi"];
                string pass = ctx.Kullanicilar.Where(x => x.KullaniciAdi == KullaniciAdi).SingleOrDefault().Sifre;

                if (fc["Sifre"] == pass)
                {
                    Session["Kullanici"] = KullaniciAdi;
                    return RedirectToAction("Main");
                }

            }
            return View();
            
        }
        public ActionResult Main()
        {
            if (Session["Kullanici"] == null)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        


    }


}