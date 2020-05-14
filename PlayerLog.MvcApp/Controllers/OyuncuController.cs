using PlayerLog.MvcApp.DAL;
using PlayerLog.MvcApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PlayerLog.MvcApp.Controllers
{
    public class OyuncuController : Controller
    {
        // GET: Oyuncu

        
        public ActionResult Index()
        {
            using (TakimContext ctx = new TakimContext())
            {
                var oyuncular = ctx.Oyuncular.ToList();
                return View(oyuncular);
            }


        }

        
        public ActionResult Ekle()
        {
            return View();
        }

        #region FormCollection ile Insert
        //[HttpPost]
        //public ActionResult Ekle(FormCollection fc)
        //{
        //    using (TakimContext ctx = new TakimContext())
        //    {
        //        ctx.Oyuncular.Add(new Oyuncu { Ad = fc["txtAd"].Trim(), Soyad = fc["txtSoyad"].Trim(), Ulke = fc["txtUlke"].Trim(), Yas = fc["txtYas"].Trim(), Boy = fc["txtBoy"].Trim(), Kilo = fc["txtKilo"].Trim(), Bolge = fc["txtBolge"].Trim() });
        //        ctx.SaveChanges();
        //    }
        //    return View();
        //} 
        #endregion

        [HttpPost]
        public ActionResult Ekle(Oyuncu o)
        {
            if (ModelState.IsValid)
            {
                using (TakimContext ctx = new TakimContext())
                {
                    ctx.Oyuncular.Add(o);
                    int sonuc = ctx.SaveChanges();
                    if (sonuc > 0)
                    {
                        return RedirectToAction("Index");
                    }
                }

            }


            return View();
        }

        public ActionResult Duzenle(int? id)
        {
            using (TakimContext ctx = new TakimContext())
            {
                var oyn = ctx.Oyuncular.Find(id);
                return View(oyn);
            }
        }

        [HttpPost]
        public ActionResult Duzenle(Oyuncu oyn)
        {
            if (ModelState.IsValid)
            {
                using (TakimContext ctx = new TakimContext())
                {
                    ctx.Entry(oyn).State = EntityState.Modified;
                    int sonuc = ctx.SaveChanges();
                    if (sonuc > 0)
                    {
                        return RedirectToAction("Index");
                    }
                    
                }
            }
            return View(oyn);

        }

        public ActionResult Sil(int? id)
        {
            using (TakimContext ctx = new TakimContext())
            {
                var oyn = ctx.Oyuncular.Find(id);
                ctx.Oyuncular.Remove(oyn);
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }
        }
    }
}