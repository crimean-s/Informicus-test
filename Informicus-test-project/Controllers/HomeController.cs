using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Informicus_test_project.Models;

namespace Informicus_test_project.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Users()
        {
            EFUsersRepository repository = new EFUsersRepository();
            return View(repository.GetUsers());
        }

        // GET: Times
        public ActionResult Times()
        {
            string localTime = DateTime.Now.ToShortTimeString();
            var utcTime = DateTime.UtcNow;
            List<DateTime> utcAllu = new List<DateTime>();
            for (int i=0; i < 10; i++)
            {
                utcAllu.Add(utcTime.AddHours(i));
            }
            ViewBag.CurrentTime = localTime;
            ViewBag.UtcTimeList = utcAllu;
            return View();
        }


    }
}