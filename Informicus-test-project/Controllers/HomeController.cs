using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Informicus_test_project.Models;
using Domain;
using System.Configuration;
using Domain.Entities;
using Informicus_test_project.Models.ViewModels;

namespace Informicus_test_project.Controllers
{
    
    public class HomeController : Controller
    {

        EFDbContext data = new EFDbContext(ConfigurationManager.ConnectionStrings[0].ConnectionString);

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Users Groups
        public ActionResult UsersGroups()
        {
            IEnumerable<User> users = data.Users.Where(x => x.UserNickname.Length > 0);
            IEnumerable<Group> groups = data.Groups.Where(x => x.GroupName.Length > 0);

            UsersGroupViewModel ugvm = new UsersGroupViewModel
            {
                Users = users,
                Groups = groups
            };

            return View(ugvm);
        }




        // GET: Users
        public ActionResult Users()
        {
            EFUsersRepository repository = new EFUsersRepository();
            return View(repository.GetUsers());
        }

        // GET: Groups
        public ActionResult Groups()
        {
            EFUsersRepository repository = new EFUsersRepository();
            return PartialView(repository.GetGroups());
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