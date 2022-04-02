using BookInfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookInfo.Controllers
{
    public class KitapEkleController : Controller
    {
        // GET: KitapEkle
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ekle(string kitap_adi, string kitap_yazari, string kitap_aciklamasi)
        {
            EntitiesTables ent = new EntitiesTables();
            kitaplar kitap = new kitaplar();
            kitap.kitap_adi = kitap_adi;
            kitap.kitap_yazari = kitap_yazari;
            kitap.kitap_aciklama = kitap_aciklamasi;
            ent.kitaplars.Add(kitap);
            try
            {
                ent.SaveChanges();
                ViewBag.result = 1;
            }
            catch (Exception e)
            {
                ViewBag.result = 0;
                ViewBag.message = e.Message.ToString();
            }

            return View();
        }
       
    }
}