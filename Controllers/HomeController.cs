using Microsoft.AspNetCore.Mvc;
using MusteriYonetimi.Models;
using System.Collections.Generic;
using System.Diagnostics;

namespace MusteriYonetimi.Controllers
{
    public class Musteri
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
    }
    using Microsoft.EntityFrameworkCore;

public class Musteriveriyonetme : DbContext
    {
        public DbSet<Musteri> Musteriler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=musteri.db");
        }
    }