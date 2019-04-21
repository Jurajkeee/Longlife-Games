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
            ViewBag.Title = "Longlife Games";
            return View();
        }
        public ActionResult AboutUs()
        {
            ViewBag.Title = "About Us";
            return View();
        }
        public ActionResult Games()
        {
            ViewBag.Title = "Games";
            return View();
        }
        public ActionResult Tools()
        {
            ViewBag.Title = "Tools";
            return View();
        }
        public ActionResult Team()
        {
            ViewBag.Title = "Team";
            return View();
        }
        public ActionResult Blog()
        {
            ViewBag.Title = "Blog";
            return View();
        }
        public ActionResult ContactUs()
        {
            ViewBag.Title = "Contact us";
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
