using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcDERS.Models
{
    public class UrunKategoriModel
    {
        public int UrunSayisi { get; set; }
        public List<Urun> urunler { get; set; }
       
    }
}