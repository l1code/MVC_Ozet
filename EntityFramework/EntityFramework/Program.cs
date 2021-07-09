using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {





            UrunContext context = new UrunContext();

            var urunler2 = context.Urunler.ToList();
            Console.WriteLine("Veritibanı oluştu.");


            var urunler = context.Urunler.ToList();
            foreach (var urun in urunler)
            {
                Console.WriteLine("Urun adi:{0}  Fiyat:{1}  Stok Adeti: {2}, Satıştamı:{3}", urun.UrunAdi, urun.Fiyat, urun.StokAdeti, urun.Satistami);

            }
            var urun1 = context.Urunler.Find(2);
            if (urun1 != null)
            {
                context.Urunler.Remove(urun1);
                Console.WriteLine("Silme işlemi yapıldı.");
            }

            context.SaveChanges();
             urunler = context.Urunler.ToList();
            foreach (var urun in urunler)
            {
                Console.WriteLine("Urun adi:{0}  Fiyat:{1}  Stok Adeti: {2}, Satıştamı:{3}", urun.UrunAdi, urun.Fiyat, urun.StokAdeti, urun.Satistami);

            }
            var kategoriler = context.Kategoriler.ToList();
            
            foreach (var kategori in kategoriler)
            {

                Console.WriteLine("---------------------");
                Console.WriteLine(kategori.KategoriAdi);

            }









            Console.ReadLine();


            //Update GÜNCELLEME
            //var urun = context.Urunler.Find(2);

            //Console.WriteLine("Urun adi:{0}  Fiyat:{1}  Stok Adeti: {2}, Satıştamı:{3}", urun.UrunAdi, urun.Fiyat, urun.StokAdeti, urun.Satistami);

            //urun.StokAdeti += 100;
            //urun.Fiyat *= 1.5;

            //context.SaveChanges();
            //Console.WriteLine("Urun adi:{0}  Fiyat:{1}  Stok Adeti: {2}, Satıştamı:{3}", urun.UrunAdi, urun.Fiyat, urun.StokAdeti, urun.Satistami);

            //-----------//-----------//-----------//-----------//-----------//-----------//-----------//-----------

            //var urunler = context.Urunler.ToList();
            //foreach (var urun in urunler)
            //{
            //    Console.WriteLine("Urun adi:{0}  Fiyat:{1}  Stok Adeti: {2}, Satıştamı:{3}", urun.UrunAdi, urun.Fiyat, urun.StokAdeti, urun.Satistami);

            //}

            //Console.WriteLine("-----------------------");

            //foreach (var urun in urunler)
            //{

            //    urun.Fiyat *= 2;
            //    urun.StokAdeti -= 20;
            //    Console.WriteLine("Urun adi:{0}  Fiyat:{1}  Stok Adeti: {2}, Satıştamı:{3}", urun.UrunAdi, urun.Fiyat, urun.StokAdeti, urun.Satistami);


            //}
            //context.SaveChanges();



            /// SELECTİNG SEÇME VERİ GETİRME
            //List<Kategori> kategoriler = context.Kategoriler.ToList();
            //foreach (var kategori in kategoriler)
            //{
            //    Console.WriteLine("Kategori Id: {1}    Kategori Adı: {0}     ",kategori.KategoriAdi,kategori.Id);
            //}
            //Console.ReadLine();
            //-----------//-----------//-----------//-----------//-----------//-----------//-----------//-----------//-----------

            //var urunler = context.Urunler.ToList();
            //foreach (var urun in urunler)
            //{
            //    Console.WriteLine("Urun adi:{0}  Fiyat:{1}  Stok Adeti: {2}, Satıştamı:{3}", urun.UrunAdi, urun.Fiyat, urun.StokAdeti, urun.Satistami);

            //}
            //-----------//-----------//-----------//-----------//-----------//-----------//-----------//-----------//-----------//-----------
            //var urun = context.Urunler.Find(3);
            //Console.WriteLine("Urun Id: {4} Urun adi:{0}  Fiyat:{1}  Stok Adeti: {2}, Satıştamı:{3}", urun.UrunAdi, urun.Fiyat, urun.StokAdeti, urun.Satistami,urun.Id);



            //İNSERT VERİ EKLEME
            //List<Urun> urunler = new List<Urun>()
            //{
            //    new Urun(){UrunAdi="Samsung S1", Fiyat=2000, StokAdeti=100,Satistami=true },
            //    new Urun(){UrunAdi="Samsung S2", Fiyat=3000, StokAdeti=100,Satistami=true },
            //    new Urun(){UrunAdi="Samsung S3", Fiyat=4000, StokAdeti=100,Satistami=true },
            //    new Urun(){UrunAdi="Samsung S4", Fiyat=5000, StokAdeti=100,Satistami=true },
            //    new Urun(){UrunAdi="Samsung S5", Fiyat=6000, StokAdeti=100,Satistami=true },
            //    new Urun(){UrunAdi="Samsung S6", Fiyat=7000, StokAdeti=100,Satistami=true }
            //};

            //foreach (var urun in urunler)
            //{
            //    context.Urunler.Add(urun);
            //}

            //context.SaveChanges();

            //Console.WriteLine("Ekleme kaydedildi.");
            //-----------//-----------//-----------//-----------//-----------//-----------//-----------//-----------


            //List<Kategori> kategoriler = new List<Kategori>()
            //{
            //    new Kategori() { Id=1,KategoriAdi="Telefon"},
            //    new Kategori() { Id=2,KategoriAdi="Tablet"},
            //    new Kategori() { Id=3,KategoriAdi="Bilgisayar"}
            //};
            //kategoriler.Add(k);

            //// Id girmiyoruz çünkü veritabanı otomatik olarak birincil anahtar yapar
            ////Ve Id otomatik olarak atanır
            //Kategori k = new Kategori();
            ////k.Id = 4;
            //k.KategoriAdi = "Bilgisayar";

            //UrunContext db = new UrunContext();
            //db.Kategoriler.Add(k);
            //db.SaveChanges();






        }
    }
}
