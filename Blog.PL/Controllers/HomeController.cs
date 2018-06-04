using Blog.BLL.DataModel;
using Blog.DAL.Context;
using Blog.DAL.Repostories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.PL.Controllers
{
    public class HomeController : Controller
    {
        BlogContext ent = new BlogContext();
        public ActionResult Index()
        {
            return View();
        }
       
    }
}