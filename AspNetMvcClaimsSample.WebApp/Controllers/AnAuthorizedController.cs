using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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