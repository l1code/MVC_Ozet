using mvcDERS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcDERS.Controllers
{
    public class ModelController : Controller
    {
        // GET: Model
        public ActionResult Index()
        {

            UrunKategoriModel model = new UrunKategoriModel();
            model.UrunSayisi = Veritabani.Liste.Where(i => i.Satistami == true).Count();
            model.urunler = Veritabani.Liste.Where(i => i.Satistami == true).ToList();



            return View(model);
            
        }

        [HttpGet]
        public ActionResult UrunEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UrunEkle(Urun entity)
        
        {
            
            Veritabani.Elemanekle(entity);
            return View("UrunListe",Veritabani.Liste);
        }

        public ActionResult Details(int id)
        {
            var urun = Veritabani.Liste.Where(i => i.UrunId == id).FirstOrDefault();
            return View(urun);
        }

      


    }
}