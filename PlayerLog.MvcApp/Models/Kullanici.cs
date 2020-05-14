using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlayerLog.MvcApp.Models
{
    public class Kullanici
    {
        public int KullaniciId { get; set; }

        public  string KullaniciAdi { get; set; }
        public string Ad { get; set; }
        public string Sifre { get; set; }
        
    }
}