using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcDERS.Models
{
    public static class Veritabani
    {

        //Sanal Veritabanı
        //Uygulama arkasında fiziksel bir dosyada saklanmıyor.
        //bilgiler bellekte saklanır.   
        public static List<Urun> _liste;
        
        static Veritabani()
        {
            _liste = new List<Urun>() { new Urun() { UrunId = 1, UrunAdi = "Samsung S5", Aciklama = "Lorem ipsum, or lipsum as it is sometimes known, is dummy text used in laying out print, graphic or web designs. The passage is attributed to an unknown typesetter in the 15th century who is thought to have scrambled parts of Cicero's De Finibus Bonorum et Malorum for use in a type specimen book. It usually begins with:“Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.”", Fiyat = 1000, Satistami = true ,resim="1.png"},
            new Urun() { UrunId = 2, UrunAdi = "Samsung S7", Aciklama = "Lorem ipsum, or lipsum as it is sometimes known, is dummy text used in laying out print, graphic or web designs. The passage is attributed to an unknown typesetter in the 15th century who is thought to have scrambled parts of Cicero's De Finibus Bonorum et Malorum for use in a type specimen book. It usually begins with:“Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.”", Fiyat = 2000, Satistami = false,resim="1.jpg" },
            new Urun() { UrunId = 3, UrunAdi = "Iphone S6", Aciklama = "idare eder3", Fiyat = 3000, Satistami = true ,resim="1.png"},
            new Urun() { UrunId = 4, UrunAdi = "Note S3", Aciklama = "idare eder4", Fiyat = 4000, Satistami = false,resim="2.jpg" },
            new Urun() { UrunId = 5, UrunAdi = "Samsung S5Nt12", Aciklama = "idare eder5", Fiyat = 1000, Satistami = true,resim="1.png" },
            new Urun() { UrunId = 6, UrunAdi = "Samsung Sırver7", Aciklama = "idare eder6", Fiyat = 2000, Satistami = false,resim="1.jpg" },
            new Urun() { UrunId = 7, UrunAdi = "Iphone SZ6", Aciklama = "idare eder7", Fiyat = 3000, Satistami = true,resim="3.jpg" },
            new Urun() { UrunId = 8, UrunAdi = "Note S3", Aciklama = "idare eder8", Fiyat = 4000, Satistami = false }
        };    
        }

        public static List<Urun> Liste
        {
            get { return _liste; }
        }

        public static void Elemanekle(Urun entity)
        {
            _liste.Add(entity);
        }



        //Veritabanu.UrunDetay(5)  5 id'li elamanı geri döndürür.
        public static Urun UrunDetay(int urunid)
        {
            Urun entity = null;
            foreach (var urun in _liste)
            {
                if (urun.UrunId==urunid)
                {
                    entity = urun;
                }
            }
            return entity;
        }

    }
}