using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcDERS.Models
{
    public class Urun
    {

        public int UrunId { get; set; }
        public string UrunAdi { get; set; }
        public string Aciklama { get; set; }
        public double Fiyat { get; set; }
        public string resim { get; set; }
        public bool Satistami { get; set; }
    }
}