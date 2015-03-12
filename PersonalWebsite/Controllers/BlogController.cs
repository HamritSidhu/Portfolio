using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalWebsite.Controllers
{
    public class BlogController : Controller
    {
      

        public ActionResult Index()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

       
    }
}