using BookInfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookInfo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Kitap()
        {
            EntitiesTables ent = new EntitiesTables();
            List<kitaplar> kitap = ent.kitaplars.ToList();
            return View(kitap);
        }

    }
}