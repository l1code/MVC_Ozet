using mvcDERS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcDERS.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public PartialViewResult KategoriMenu()
        {
            List<category> categories = new List<category>()
            {
                new category() { categoryId = 1, categoryName = "Telefonlar" },
                new category() { categoryId = 1, categoryName = "Tapletler" },
                new category() { categoryId = 1, categoryName = "Televizyonlar" }
            };
            return PartialView("KategoriMenu",categories);
        }
    }
}