﻿using System.Web.Mvc;

namespace AspNetMvcClaimsSample.WebApp.Controllers
{
    public class AnAuthorizedController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
    }
}