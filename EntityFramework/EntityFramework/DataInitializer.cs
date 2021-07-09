using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
   public  class DataInitializer : DropCreateDatabaseIfModelChanges<UrunContext>
    {

        protected override void Seed(UrunContext context)
        {

            List<Kategori> kategoriler = new List<Kategori>()
            {
                new Kategori(){KategoriAdi="Telefon"},
                new Kategori(){KategoriAdi="Beyaz Eşya"},
                new Kategori(){KategoriAdi="Bilgisayar"},
                new Kategori(){KategoriAdi="Mobilya"}
            };

            foreach (var kategori in kategoriler)
            {
                context.Kategoriler.Add(kategori);
            }
            context.SaveChanges();



            List<Urun> urunler = new List<Urun>()
            {
                new Urun(){UrunAdi="Samsung s1",Fiyat=2567,StokAdeti=20,Satistami=true},
                new Urun(){UrunAdi="Samsung s2",Fiyat=3567,StokAdeti=50,Satistami=true},
                new Urun(){UrunAdi="Samsung s3",Fiyat=4567,StokAdeti=20,Satistami=true},
                new Urun(){UrunAdi="Samsung s4",Fiyat=5567,StokAdeti=50,Satistami=true},
                new Urun(){UrunAdi="Samsung s5",Fiyat=6567,StokAdeti=250,Satistami=true},
                new Urun(){UrunAdi="Samsung s6",Fiyat=7567,StokAdeti=250,Satistami=true},
            };

            foreach (var urun in urunler)
            {
                context.Urunler.Add(urun);
            }
            context.SaveChanges();


           



            base.Seed(context);
        }

    }
}
