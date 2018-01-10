using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstLook.Models;

namespace FirstLook.Controllers
{
    public class MailingController : Controller
    {
        // GET: Mailing
        public ActionResult Index()
        {
            Mailing m1 = new Mailing();
            m1.FirstName = "Ron";
            m1.LastName = "Nims";
            m1.Email = "rln@aol.com";
            Mailing m2 = new Mailing();
            m2.FirstName = "Oprah";
            m2.LastName = "Winfrey";
            m2.Email = "oprah@aol.com";
            Mailing m3 = new Mailing();
            m3.FirstName = "Joe";
            m3.LastName = "Biden";
            m3.Email = "job@gmail.com";

            List<Mailing> mailings = new List<Mailing>();
            mailings.Add(m1);
            mailings.Add(m2);
            mailings.Add(m3);


            return View(mailings);

        }
    }
}