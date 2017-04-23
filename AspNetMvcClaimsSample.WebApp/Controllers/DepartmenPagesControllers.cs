using AspNetMvcClaimsSample.WebApp.Filters;
using System.Web.Mvc;

namespace AspNetMvcClaimsSample.WebApp.Controllers
{
    [DeparmentAuthorize(AuthorizedDepartments = "1")]
    public class Departmen1PagesController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }

    public class Departmen2PagesController : Controller
    {
        public ActionResult Welcome()
        {
            return View();
        }

        [DeparmentAuthorize(AuthorizedDepartments = "1,2")]
        public ActionResult Index()
        {
            return View();
        }

        [DeparmentAuthorize(AuthorizedDepartments = "2")]
        public ActionResult OnlyDep2()
        {
            return View();
        }
    }
}