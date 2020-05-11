using PlayerLog.MvcApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PlayerLog.MvcApp.DAL
{
    public class TakimContext:DbContext
    {
        public TakimContext():base("cstr")
        {

        }


        public DbSet<Oyuncu> Oyuncular { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Oyuncu>().ToTable("tblOyuncular");

            modelBuilder.Entity<Oyuncu>().Property(o => o.Ad).HasColumnType("varchar").HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Oyuncu>().Property(o => o.Soyad).HasColumnType("varchar").HasMaxLength(75).IsRequired();
            modelBuilder.Entity<Oyuncu>().Property(o => o.Ulke).HasColumnType("varchar").HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Oyuncu>().Property(o => o.Yas).HasColumnType("varchar").IsRequired();
            modelBuilder.Entity<Oyuncu>().Property(o => o.Boy).HasColumnType("varchar").IsRequired();
            modelBuilder.Entity<Oyuncu>().Property(o => o.Kilo).HasColumnType("varchar").IsRequired();
            modelBuilder.Entity<Oyuncu>().Property(o => o.Bolge).HasColumnType("varchar").HasMaxLength(10).IsRequired();

        }
    }
}