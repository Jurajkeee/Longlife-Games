using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MongoDB.Driver;
using System.Configuration;

namespace LonglifeGames.App_Start
{
    public class MongoConfig
    {
        public IMongoDatabase database;
        public MongoConfig()
        {
            //var mongoclient = new MongoClient(ConfigurationSettings.AppSettings["MongoDBHost"]);
            //database = mongoclient.GetDatabase(ConfigurationSettings.AppSettings["MongoDBName"]);
            string connectionString = "mongodb://CRUD:yrebevaty2123@213.109.226.196:27017/lg_articles";
            MongoClient client = new MongoClient(connectionString);
            database = client.GetDatabase("lg_articles"); 
        }
    }
}
