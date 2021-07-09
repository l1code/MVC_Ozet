using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class Urun
    {
        public int Id { get; set; }
        public string UrunAdi { get; set; }
        public double Fiyat { get; set; }
        public int StokAdeti { get; set; }
        public bool Satistami { get; set; }

        public int KategoriId { get; set; }


        public List<Tedarikci> Tedarikci { get; set; }  


        //Bu kısım veritabanına etki etmez sadece bu program içersinde işimi kolaylaştıracak.
        public Kategori Kategori { get; set; }

    }
}
