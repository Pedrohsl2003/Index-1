using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Retorno(string Login, string senha)
        {
            ViewBag.Login = Login;
            ViewBag.senha = senha;

            return View();
        }
    }
}