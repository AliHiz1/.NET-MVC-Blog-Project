using PagedList;
using PagedList.Mvc;
using System;
using System.Collections.Generic;
using System.Fabric.Query;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;
namespace TravelTripProje.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        
        [Authorize]
        public ActionResult Index()
        {
            var degerler = c.Blogs.ToList();
            return View(degerler);
        }
        [HttpGet]
        [Authorize]
        public ActionResult YeniBlog()
        {
            return View();
        }
        [HttpPost]
        [Authorize]
        [ValidateInput(false)]
        public ActionResult YeniBlog(Blog p)
        {
            p.Tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
            c.Blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult BlogSil(int id)
        {
            var b = c.Blogs.Find(id);
            c.Blogs.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult BlogGetir(int id)
        {
           var bl = c.Blogs.Find(id);
           return View("BlogGetir", bl);
        }
        [Authorize]
        public ActionResult BlogGuncelle(Blog b)
        {
            var blg = c.Blogs.Find(b.ID);
            blg.Aciklama = b.Aciklama;
            blg.Baslik = b.Baslik;
            blg.BlogImage = b.BlogImage;
            blg.Tarih = b.Tarih;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult YorumListesi()
        {
            var yorumlar = c.Yorumlars.ToList();
            return View(yorumlar);
        }
    //public ActionResult YorumListesi(int page = 1, int pagesize = 5)
    //{
    //    List<Yorumlar> yorumlr = new List<Yorumlar>();
    //    for(int i = 0; i <= 15; i++)
    //    {
    //        Yorumlar yorumListe = new Yorumlar();
    //        yorumListe.ID = i;
    //        yorumListe.KullaniciAdi = "test user name -" + i;
    //        yorumListe.Mail = "test user mail -" + i;
    //        yorumListe.Yorum = "test user comment -" + i;

    //        yorumlr.Add(yorumListe);
    //    }
    //    PagedList<Yorumlar> yorumModel = new PagedList<Yorumlar> { yorumlr, page, pagesize };
    //    return View(yorumModel);
    //}
    [Authorize]
        public ActionResult YorumSil(int id)
        {
            var b = c.Yorumlars.Find(id);
            c.Yorumlars.Remove(b);
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
        [Authorize]
        public ActionResult YorumGetir(int id)
        {
            var yr = c.Yorumlars.Find(id);
            return View("YorumGetir", yr);
        }
        [Authorize]
        public ActionResult YorumGuncelle(Yorumlar y)
        {
            var yrm = c.Yorumlars.Find(y.ID);
            yrm.KullaniciAdi = y.KullaniciAdi;
            yrm.Mail = y.Mail;
            yrm.Yorum = y.Yorum;
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
        [Authorize]
        public ActionResult HakkimizdaListesi()
        {
            var hakkimizdalar = c.Hakkimizdas.ToList();
            return View(hakkimizdalar);
        }

        [Authorize]
        public ActionResult HakkimizdaGetir(int id)
        {
            var hk = c.Hakkimizdas.Find(id);
            return View("HakkimizdaGetir", hk);
        }
        [Authorize]
        public ActionResult HakkimizdaGuncelle(Hakkimizda h)
        {
            var hkn = c.Hakkimizdas.Find(h.ID);
            hkn.FotoUrl = h.FotoUrl;
            hkn.Aciklama = h.Aciklama;
            c.SaveChanges();
            return RedirectToAction("HakkimizdaListesi");
        }
        [Authorize]
        public ActionResult ContactListesi()
        {
            var contactlar = c.Contacts.ToList();
            return View(contactlar);
        }
        [Authorize]
        public ActionResult ContactGetir(int id)
        {
            var ct = c.Contacts.Find(id);
            return View("ContactGetir", ct);
        }
        [Authorize]
        public ActionResult ContactSil(int id)
        {
            var del = c.Contacts.Find(id);
            c.Contacts.Remove(del);
            c.SaveChanges();
            return RedirectToAction("ContactListesi");
        }
        [Authorize]
        public ActionResult ContactGuncelle(Contact co)
        {
            var ctc = c.Contacts.Find(co.ID);
            ctc.AdSoyad = co.AdSoyad;
            ctc.Mail = co.Mail;
            ctc.Url = co.Url;
            ctc.Mesaj = co.Mesaj;
            c.SaveChanges();
            return RedirectToAction("ContactListesi");
        }
        public ActionResult EBultenListesi()
        {
            var EPostalar = c.SubMails.ToList();
            return View(EPostalar);
        }
        public ActionResult EBultenSil(int id)
        {
            var del = c.SubMails.Find(id);
            c.SubMails.Remove(del);
            c.SaveChanges();
            return RedirectToAction("EBultenListesi");
        }
    }
}