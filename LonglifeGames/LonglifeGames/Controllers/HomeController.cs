using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using MongoDB.Driver;
using MongoDB.Bson;
using LonglifeGames.Models;
using LonglifeGames.App_Start;
using Westwind.Web.Markdown;

namespace LonglifeGames.Controllers
{

    public class HomeController : Controller
    {
        private MongoConfig dbConfig;
        private IMongoCollection<ArticleModel> articleCollection;

        

        public HomeController()
        {
            
            dbConfig = new MongoConfig();
            articleCollection = dbConfig.database.GetCollection<ArticleModel>("articles");
        }

        public ActionResult Index()
        {
            
            ViewBag.Title = "Longlife Games - Games for everyone";
            List<ArticleModel> articles = articleCollection.AsQueryable<ArticleModel>().OrderByDescending(id => id.Id).ToList();
            return View(articles);
            
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
            List<ArticleModel> articles = articleCollection.AsQueryable<ArticleModel>().OrderByDescending(id => id.Id).ToList();
            return View(articles);
        }
        public ActionResult ContactUs()
        {
            ViewBag.Title = "Contact us - Longlife Games";
            return View();
        }
        public ActionResult Article(string id)
        {
            
            var articleId = new ObjectId(id);
            var article = articleCollection.AsQueryable<ArticleModel>().SingleOrDefault(x => x.Id == articleId);
            ViewBag.Title = article.ArticleTitle;
            return View(article);
        }
        
        public ActionResult ToolDescription()
        {
            ViewBag.Title = "Description";
            return View();
        }

        /// Admin Panel
        


        public ActionResult LoginPage()
        {
            ViewBag.Title = "Login";
            return View();
        }
        [HttpPost]
        public ActionResult LoginPage(string login, string password)
        {
            ViewBag.Title = "Login";
            if("Qt+h4AyLtp3fj+MZGjy7CQ==".Equals(login) && "WM7bnDigoQYpV7K3h7qixQ==".Equals(password))
            {
                
                Session["user"] = new LoginModel() { Login = login,
                                                     Password = password,
                                                     DateTime = DateTime.Now.ToString(),
                                                     IP = System.Web.HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] };
                return RedirectToAction("AdminPanel", "Home");
            }
            //LoginModel admin = new LoginModel
            //{
            //    Login = "Qt+h4AyLtp3fj+MZGjy7CQ==",
            //    Password = "WM7bnDigoQYpV7K3h7qixQ=="
            //};
            return RedirectToAction("Index", "Home");
        }
        //[ValidateAntiForgeryToken]
        public ActionResult AdminPanel()
        {
            if (Session["user"] == null)
            {
                return RedirectToAction("Error","Shared");
            }
            List<ArticleModel> articles = articleCollection.AsQueryable<ArticleModel>().OrderByDescending(id => id.Id).ToList();
            ViewBag.Title = "Admin Panel - Longlife Games";
            return View(articles);
        }
        public ActionResult LogOut()
        {
            if (Session["user"] == null)
            {
                return RedirectToAction("Error", "Shared");
            }
            Session.Clear();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult ArticleCreate()
        {
            if (Session["user"] == null)
            {
                return RedirectToAction("Error", "Shared");
            }
            ViewBag.Title = "New Article - Longlife Games";
            return View();
        }
        [HttpPost]
        public ActionResult ArticleCreate(ArticleModel article)
        {
            
            try
            {
                if (Session["user"] == null)
                {
                    return RedirectToAction("Error", "Shared");
                }
                articleCollection.InsertOne(article);
                return RedirectToAction("AdminPanel","Home");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult ArticleUpdate(string id)
        {
            if (Session["user"] == null)
            {
                return RedirectToAction("Error", "Shared");
            }
            
            var articleId = new ObjectId(id);
            var article = articleCollection.AsQueryable<ArticleModel>().SingleOrDefault(x => x.Id == articleId);
            ViewBag.Title = article.ArticleTitle;
            return View(article);
        }
        [HttpPost]
        public ActionResult ArticleUpdate(string id, ArticleModel article)
        {
            try
            {
                if (Session["user"] == null)
                {
                    return RedirectToAction("Error", "Shared");
                }
                var filter = Builders<ArticleModel>.Filter.Eq("_id", ObjectId.Parse(id));
                var update = Builders<ArticleModel>.Update
                                .Set("title", article.ArticleTitle)
                                .Set("author", article.ArticleAuthor)
                                .Set("content", article.ArticleContent)
                                .Set("image", article.ArticleImage);
                var result = articleCollection.UpdateOne(filter, update);
                return RedirectToAction("AdminPanel", "Home");
            }
            catch
            {
                return RedirectToAction("Index", "Home");
            }
            
        }
        public ActionResult ArticleDelete(string id, FormCollection collection)
        {
            try
            {
                if (Session["user"] == null)
                {
                    return RedirectToAction("Error", "Shared");
                }
                articleCollection.DeleteOne(Builders<ArticleModel>.Filter.Eq("_id", ObjectId.Parse(id)));
                return RedirectToAction("AdminPanel", "Home");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }

    }
}
