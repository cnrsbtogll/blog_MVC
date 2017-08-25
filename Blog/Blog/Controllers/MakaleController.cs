using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers
{
    using App_Classes;
    using Models;
    using System.Drawing;

    [Authorize]
    public class MakaleController : Controller
    {
        // GET: Makale
        blog_iozContext context = new blog_iozContext();
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult Detay(int id)
        {
            var data = context.Makales.FirstOrDefault(x => x.MakaleId == id);
            return View(data);
        }
        [Authorize(Roles = "Admin")]
        public ActionResult MakaleEkle()
        {
            return View();
        }
        [AllowAnonymous]
        public string Begen(int id)
        {
            Makale mkl = context.Makales.FirstOrDefault(x => x.MakaleId == id);
            mkl.BegeniSayisi++;
            context.SaveChanges();
            return mkl.BegeniSayisi.ToString();
        }
        [Authorize(Roles ="Admin,Yazar")]
        public ActionResult Ekle()
        {
            ViewBag.Kategoriler = context.Kategoris.ToList();
            return View();
        }
        [Authorize(Roles = "Admin,Yazar")]
        [HttpPost]
        public ActionResult Ekle(Makale mkl, HttpPostedFileBase resim)
        {
            Image img = Image.FromStream(resim.InputStream);
            Bitmap kckResim = new Bitmap(img, Settings.ResimKucukBoyut);
            Bitmap ortaResim = new Bitmap(img, Settings.ResimOrtaBoyut);
            Bitmap bykResim = new Bitmap(img, Settings.ResimBuyukBoyut);
            kckResim.Save(Server.MapPath("/Content/MakaleResim/KucukBoyut/" + resim.FileName));
            ortaResim.Save(Server.MapPath("/Content/MakaleResim/OrtaBoyut/" + resim.FileName));
            bykResim.Save(Server.MapPath("/Content/MakaleResim/BuyukBoyut/" + resim.FileName));

            Resim rsm = new Resim();
            rsm.KucukBoyut = "/Content/MakaleResim/KucukBoyut/" + resim.FileName;
            rsm.OrtaBoyut = "/Content/MakaleResim/OrtaBoyut/" + resim.FileName;
            rsm.BuyukBoyut = "/Content/MakaleResim/BuyukBoyut/" + resim.FileName;
            context.Resims.Add(rsm);
            context.SaveChanges();
            mkl.ResimID = rsm.ResimId;
            mkl.EklenmeTarihi = DateTime.Now;
            mkl.GorontulenmeSayisi = 0;
            mkl.BegeniSayisi = 0;
            int yzrId = context.Kullanicis.FirstOrDefault(x => x.KullaniciAdi == User.Identity.Name).KullaniciId;
            mkl.YazarID = yzrId;
            context.Makales.Add(mkl);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");

        }
    }
}