using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers
{
    using Models;
    public class EtiketController : Controller
    {
        // GET: Etiket
        blog_iozContext context = new blog_iozContext();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult EtiketlerWidget()
        {
            return PartialView(context.Etikets.ToList());
        }
    }
}