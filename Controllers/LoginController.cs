using BookInfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookInfo.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string Username, string Password)
        {
            EntitiesTables ent = new EntitiesTables();
            List<kullanicilar> userList = ent.kullanicilars.Where(user => user.kullanici_adi == Username && user.kullanici_sifre == Password).ToList();
            int result = userList.Count();
            if (result == 1)
            {
                return Redirect("/Home/Index");
            }
            else if (result == 0)
            {
                ViewBag.error = "Lütfen bilgilerinizi kontrol edin.";
                return View();
            }
            return View();
        }
    }
}
