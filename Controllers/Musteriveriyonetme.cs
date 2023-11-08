using System;
using System.Linq;

class Program
{
    static void Main()
    {
        using (var db = new MusteriDbContext())
        {
            db.Musteriler.Add(new Musteri { Ad = "Ahmet", Soyad = "Yılmaz", Email = "ahmet@example.com" });
            db.Musteriler.Add(new Musteri { Ad = "Ayşe", Soyad = "Kara", Email = "ayse@example.com" });
            db.SaveChanges();
            var musteriler = db.Musteriler.ToList();
            foreach (var musteri in musteriler)
            {
                Console.WriteLine($"ID: {musteri.Id}, Ad: {musteri.Ad}, Soyad: {musteri.Soyad}, Email: {musteri.Email}");
            }
        }
    }
}



