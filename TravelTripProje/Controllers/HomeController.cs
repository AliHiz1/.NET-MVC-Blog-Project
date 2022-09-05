using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class HomeController : Controller
    {
        Context c = new Context();
        //[HttpGet]
        //public PartialViewResult Index()
        //    {
        //    SubMail SM = new SubMail();
        //        return PartialView();
        //    }
        //[HttpPost]
        //public PartialViewResult Index(SubMail SM)
        //{
        //    SubMail SBM = new SubMail();
        //    SBM.SubEMail = SM.SubEMail;
        //    c.SubMails.Add(SBM);
        //    c.SaveChanges();
        //    return RedirectToAction("Index");
        //}
    }
}
