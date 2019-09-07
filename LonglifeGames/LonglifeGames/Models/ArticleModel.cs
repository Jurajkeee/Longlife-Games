using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace LonglifeGames.Models
{
    public class ArticleModel
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("title")]
        public string ArticleTitle { get; set; } = "No Info";
        [BsonElement("author")]
        public string ArticleAuthor { get; set; } = "No Info";
        [BsonElement("content")]
        public string ArticleContent { get; set; } = "No Info";
        [BsonElement("image")]
        public string ArticleImage { get; set; } = "https://x.kinja-static.com/assets/images/logos/placeholders/default.png";
    }
}
