using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers
{
    using Models;
    public class MakaleController : Controller
    {
        // GET: Makale
        blog_iozContext context = new blog_iozContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Detay(int id)
        {
            var data = context.Makales.FirstOrDefault(x => x.MakaleId == id);
            return View(data);
        }
    }
}