using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace LonglifeGames.Controllers
{

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Longlife Games - Games for everyone";
            return View();
        }
        public ActionResult AboutUs()
        {
            ViewBag.Title = "Longlife Games - About Us";
            return View();
        }
        public ActionResult Games()
        {
            ViewBag.Title = "Longlife Games - Games";
            return View();
        }
        public ActionResult Tools()
        {
            ViewBag.Title = "Longlife Games - Tools";
            return View();
        }
        public ActionResult Team()
        {
            ViewBag.Title = "Longlife Games - Team";
            return View();
        }
        public ActionResult Blog()
        {
            ViewBag.Title = "Longlife Games - Blog";
            return View();
        }
        public ActionResult ContactUs()
        {
            ViewBag.Title = "Contact us - Longlife Games";
            return View();
        }
        public ActionResult Article()
        {
            ViewBag.Title = "Article";
            return View();
        }
        public ActionResult ToolDescription()
        {
            ViewBag.Title = "Description";
            return View();
        }
    }
}
