using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers
{
    using Models;
    using App_Classes;
    public class HomeController : Controller
    {
        // GET: Home
        blog_iozContext context = new blog_iozContext();
        public ActionResult Index()
        {

            return View();
        }
        public PartialViewResult MakaleListele()
        {
            return PartialView("MakaleListeleWidget",context.Makales.ToList());
        }
        public PartialViewResult PopularMakalelerWidget()
        {
            var model = context.Makales.OrderByDescending(x => x.EklenmeTarihi).Take(3).ToList();
            return PartialView(model);
        }
    }
}