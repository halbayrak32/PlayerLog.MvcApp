using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PlayerLog.MvcApp.Models
{
    public class Oyuncu
    {
        public int OyuncuId { get; set; }

        [Display(Name ="Oyuncu Adı")]
        [Required(ErrorMessage = "Oyuncu Soyadı Giriniz!")]
        public string Ad  { get; set; }

        [Display(Name = "Oyuncu Soyadı")]
        [Required(ErrorMessage = "Oyuncu Adı Giriniz!")]
        public string Soyad { get; set; }

        [Display(Name = "Oyuncu Ülkesi")]
        [Required]
        public string Ulke { get; set; }

        [Display(Name = "Oyuncu Yaşı")]
        [Required]
        public string Yas { get; set; }

        [Display(Name = "Oyuncu Boyu")]
        [Required]
        public string Boy { get; set; }

        [Display(Name = "Oyuncu Kilosu")]
        [Required]
        public string Kilo { get; set; }

        [Display(Name = "Oyuncu Bölgesi")]
        [Required]
        public string Bolge { get; set; }





    }
}