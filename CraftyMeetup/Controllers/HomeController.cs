﻿using System.Web.Mvc;

namespace CraftyMeetup.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
    }
}