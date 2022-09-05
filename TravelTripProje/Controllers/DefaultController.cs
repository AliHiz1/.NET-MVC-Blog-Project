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
    public class DefaultController : Controller
    {
        // GET: Default
        Context c = new Context();
        SubMail by = new SubMail();
        public ActionResult Index()
        {
            var degerler = c.Blogs.Take(4).ToList();
            return View(degerler);
        }
        public PartialViewResult Partial1()
        {
            var degerler = c.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            return PartialView(degerler);
        }
        public ActionResult Ebulten(string emailaddress)
        {

            if (!string.IsNullOrEmpty(emailaddress))
            {
               
                //var by = c.SubMails.Where(x => x.SubEMail == emailaddress).FirstOrDefault();
                int isMail = c.SubMails.Where(mail => mail.SubEMail == emailaddress).Select(y => y.ID).FirstOrDefault();

                if (isMail >= 1)
                {
                    ModelState.AddModelError("", "Bu Mail Adresi Daha Önce Kayıtlı");
                }
                else
                {
                    SubMail kayit = new SubMail();
                    kayit.SubEMail = emailaddress;
                    c.SubMails.Add(kayit);
                    c.SaveChanges();
                }
            }
            return View("Index");
        }
        //[HttpGet]
        //public ActionResult SendMail()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public ActionResult SendMail(Contact model)
        //{


        //    MailMessage mailim = new MailMessage();
        //    mailim.To.Add("alihizz01@gmail.com");
        //    mailim.From = new MailAddress("alihizz01@gmail.com");
        //    mailim.Subject = "Blogumuza abone olun:";
        //    mailim.Body = "Sayın yetkili " + model.AdSoyad + " kişisinden gelen mesaj aşağıdaki gibidir. <br>" + model.Mesaj;
        //    mailim.IsBodyHtml = true;

        //    SmtpClient smtp = new SmtpClient();
        //    smtp.Credentials = new NetworkCredential("alihizz01@gmail.com", "boston1268793");
        //    smtp.Port = 587;
        //    smtp.Host = "smtp.gmail.com";
        //    smtp.EnableSsl = true;

        //    try
        //    {
        //        smtp.Send(mailim);
        //        TempData["Message"] = "Mesaj iletilmiştir";

        //    }
        //    catch (Exception ex)
        //    {
        //        TempData["Message"] = "Mesaj gönderilemedi. Hata nedeni: " + ex.Message;
        //    }

        //    return View();
        //}
    }
}