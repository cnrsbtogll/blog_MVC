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
        public ActionResult Index(int id)
        {
            return View(id);
        }
        public PartialViewResult EtiketlerWidget()
        {
            return PartialView(context.Etikets.ToList());
        }
        public ActionResult MakaleListele(int id)
        {
            var data = context.Makales.Where(x => x.Etikets.Any(y => y.EtiketId == id)).ToList();
            return View("MakaleListeleWidget", data);
        }
    }
}