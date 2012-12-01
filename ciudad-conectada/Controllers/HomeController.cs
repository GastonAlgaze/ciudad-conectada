using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ciudad_conectada.Models;
using ciudad_conectada.Services;

namespace ciudad_conectada.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult LoadNotifications()
        {
            return View();
        }

        public ActionResult AddNotification(Notification notification)
        {
            NotificationsService.Instance.AddNotification(notification);
            return Json(null);
        }
    }
}
