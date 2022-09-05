using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;
namespace TravelTripProje.Controllers
{
    public class ContactController : Controller
    {
        Context c = new Context();
        Blog blog = new Blog();
        public ActionResult Index()
        {
            Contact ccc = new Contact();
            return View("Index",ccc);
        }
        [HttpPost]
        public ActionResult Index(Contact ccc)
        {
            if (ModelState.IsValid)
            {
                Contact kayit = new Contact();
                kayit.AdSoyad = ccc.AdSoyad;
                kayit.Mail = ccc.Mail;
                kayit.Url = ccc.Url;
                kayit.Mesaj = ccc.Mesaj;

                c.Contacts.Add(kayit);
                c.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(ccc);
            }

        }
        
    }
}