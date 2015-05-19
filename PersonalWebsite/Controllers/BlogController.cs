using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MongoDB.Driver;
using PersonalWebsite.App_Start;
using MongoDB.Driver.Builders;
using PersonalWebsite.DAL.Blog;
using MongoDB.Bson;

namespace PersonalWebsite.Controllers
{
    public class BlogController : Controller
    {
        public readonly BlogContext Context = new BlogContext();
        public ActionResult Index()
        {
            var posts = Context.Posts.FindAll()
                        .SetSortOrder(SortBy<Post>.Descending(r => r.datePosted));
            
            return View(posts);
        }

        public ActionResult Post(string name) {
            var post = Context.Posts.Find(Query.EQ("route", name))
                .ToList().FirstOrDefault();

            return View(post);
        }

    }
}