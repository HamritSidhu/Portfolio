using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver;
using MongoDB.Bson;
using PersonalWebsite.Properties;
using PersonalWebsite.DAL.Blog;

namespace PersonalWebsite.App_Start
{
    public class BlogContext
    {
        public MongoDatabase database;
        public BlogContext() {
            MongoUrl url = new MongoUrl(Settings.Default.DatabaseConnectionString);
            MongoServerSettings settings = MongoServerSettings.FromUrl(url);
            MongoServer server = new MongoServer(settings);
            database = server.GetDatabase(Settings.Default.BlogDatabase);
        }

        public MongoCollection<Post> Posts {
            get {
                return database.GetCollection<Post>("posts");
            }
        }
    }
}