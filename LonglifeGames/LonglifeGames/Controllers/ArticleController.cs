//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;
//using MongoDB.Bson;
//using MongoDB.Driver.Core;
//using MongoDB.Driver;
//using System.Configuration;
//using LonglifeGames.App_Start;
//using LonglifeGames.Models;

//namespace LonglifeGames.Controllers
//{
//    public class ArticleController : Controller
//    {
//        //private MongoConfig dbConfig;
//        //private IMongoCollection<ArticleModel> articleCollection;

//        //public ArticleController()
//        //{
//        //    dbConfig = new MongoConfig();
//        //    articleCollection = dbConfig.database.GetCollection<ArticleModel>("articles");
//        //}
//        //public ActionResult Index()
//        //{
//        //    List<ArticleModel> articles = articleCollection.AsQueryable<ArticleModel>().ToList();
//        //    return View("../Views/Home/Index" , articles);
//        //}

//        //public ActionResult Blog()
//        //{
//        //    List<ArticleModel> articles = articleCollection.AsQueryable<ArticleModel>().ToList();
//        //    return View("../Views/Home/Blog", articles);
//        //}

//        //public ActionResult Article(string id)
//        //{
//        //    var articleId = new ObjectId(id);
//        //    var article = articleCollection.AsQueryable<ArticleModel>().SingleOrDefault(x => x.Id == articleId);
//        //    return View("../Views/Home/Article", article);
//        //}
//        ////[HttpGet]
//        //public ActionResult Create()
//        //{
//        //    return View();
//        //}

//        //[HttpPost]
//        //public ActionResult Create(ArticleModel article)
//        //{
//        //    try
//        //    {
//        //        articleCollection.InsertOne(article);
//        //        return RedirectToAction("Index");
//        //    }
//        //    catch
//        //    {
//        //        return View();
//        //    }
//        //}

//        //public ActionResult Edit(string id)
//        //{
//        //    var articleId = new ObjectId(id);
//        //    var article = articleCollection.AsQueryable<ArticleModel>().SingleOrDefault(x => x.Id == articleId);
//        //    return View(article);
//        //}

//        //[HttpPost]
//        //public ActionResult Edit(string id, ArticleModel article)
//        //{
//        //    try
//        //    {
//        //        var filter = Builders<ArticleModel>.Filter.Eq("_id", ObjectId.Parse(id));
//        //        var update = Builders<ArticleModel>.Update
//        //                        .Set("title", article.ArticleTitle)
//        //                        .Set("author", article.ArticleAuthor)
//        //                        .Set("content", article.ArticleContent);
//        //        var result = articleCollection.UpdateOne(filter, update);
//        //        return RedirectToAction("Index");
//        //    }
//        //    catch
//        //    {
//        //        return View();
//        //    }
//        //}

//        //public ActionResult Delete(string id)
//        //{
//        //    var articleId = new ObjectId(id);
//        //    var article = articleCollection.AsQueryable<ArticleModel>().SingleOrDefault(x => x.Id == articleId);
//        //    return View(article);
//        //}

//[HttpPost]
//public ActionResult Delete(string id, FormCollection collection)
//{
//    try
//    {
//        articleCollection.DeleteOne(Builders<ArticleModel>.Filter.Eq("_id", ObjectId.Parse(id)));
//        return RedirectToAction("Index");
//    }
//    catch
//    {
//        return View();
//    }
//}
//    }
//}