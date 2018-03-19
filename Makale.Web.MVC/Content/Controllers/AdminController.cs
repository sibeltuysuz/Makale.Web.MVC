using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Makale.Web.MVC.Content.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        [Authorize(Users = "admin")]
        public ActionResult SuperAdmin()
        {
            return View();
        }
    }
}