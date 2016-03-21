using MvcApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {

            var model = new AboutModel
            {
                Name = "Thai",Location="Bangkok, Thailand"
            };

            var listModel = new List<AboutModel>()
            {
                new AboutModel {Name="Eng", Location="London, English" },
                new AboutModel {Name="USA", Location="USA" }
            };

            return View(listModel);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}