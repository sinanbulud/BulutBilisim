using Blog.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Blog.PL
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            using (BlogContext db = new BlogContext())
            {
                db.Database.CreateIfNotExists();
            }
            AreaRegistration.RegisterAllAreas();
          
            RouteConfig.RegisterRoutes(RouteTable.Routes);
          
        }
    }
}
