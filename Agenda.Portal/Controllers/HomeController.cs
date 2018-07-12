using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Agenda.Portal.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Pesssoa()
        {
            return View("Pessoa");
        }

        [HttpGet]
        public ActionResult Categoria()
        {
            return View("Categoria");
        }
        
    }
}