using System.Web.Mvc;

namespace AspNetMvcClaimsSample.WebApp.Controllers
{
    [Authorize(Roles = "Admin,Operator")]
    public class CustomPagesController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}