using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Informicus_test_project.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Register()
        {
            return View();
        }

        public ActionResult RegisterUser(int id)
        {
            ViewBag.UserType = id;
            return View();
        }
    }
}