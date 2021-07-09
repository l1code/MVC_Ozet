using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class Tedarikci
    {
        public int Id { get; set; }
        public string Firma { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }

        public List<Urun> Urunler { get; set; }

    }
}
