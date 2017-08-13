using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers
{
    using Models;
    public class KategoriController : Controller
    {
        // GET: Kategori
        blog_iozContext context = new blog_iozContext();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult KategoriWidget()
        {
            return PartialView(context.Kategoris.ToList());
        }
    }
}