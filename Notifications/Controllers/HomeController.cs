using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Notifications.DAL;
using System.Web.Script.Serialization;

namespace Notifications.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var db = new NotificationsContext())
            {
                var list = db.Notifications.ToList();

                return View(list);
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}