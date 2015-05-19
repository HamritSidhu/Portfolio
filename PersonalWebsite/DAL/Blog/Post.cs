using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonalWebsite.DAL.Blog
{
    public class Post
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string title { get; set; }

        public string route { get; set; }

        public string description { get; set; }

        [BsonRepresentation(BsonType.DateTime)]
        public DateTime datePosted { get; set; }

        public string content { get; set; }
    }
}