﻿using MementoHealth.Classes;
using System.Web.Mvc;

namespace MementoHealth.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (User.IsInRole(Role.SysAdmin))
                return RedirectToAction("Index", "Providers");
            if (User.IsInRole(Role.ProviderAdmin))
                return RedirectToAction("Index", "Forms");
            if (User.IsInRole(Role.Doctor) || User.IsInRole(Role.Assistant))
                return RedirectToAction("Index", "Patients");
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}