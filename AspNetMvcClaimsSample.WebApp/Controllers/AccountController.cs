using AspNetMvcClaimsSample.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Microsoft.Owin.Security;
using System.Security.Claims;
using AspNetMvcClaimsSample.WebApp.Services;
using System.Web;

namespace AspNetMvcClaimsSample.WebApp.Controllers
{
    public class AccountController : Controller
    {
        ILoginService _loginService;

        public AccountController() //ILoginService loginService 
        {
            //TODO : Inject 'LoginService'
            //_loginService = loginService;
            _loginService = new LoginService();
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel model, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = _loginService.GetUser(model.UserName, model.Password);
            if (user != null)
            {
                //TODO : Move this outside
                #region Signin
                var claims = new List<Claim>();

                claims.Add(new Claim(ClaimTypes.NameIdentifier, user.UserName));
                claims.Add(new Claim(ClaimTypes.Name, user.UserName));

                var identity = new ClaimsIdentity(claims, DefaultAuthenticationTypes.ApplicationCookie);

                AuthenticationManager.SignIn(new AuthenticationProperties()
                {
                    AllowRefresh = true,
                    IsPersistent = model.RememberMe,
                    ExpiresUtc = DateTime.UtcNow.AddDays(7)
                }, identity);
                #endregion

                return Redirect(returnUrl ?? "/");
            }
            else
            {
                ModelState.AddModelError("", "Invalid login attempt.");
                return View(model);
            }
        }

        public ActionResult Logout()
        {
            AuthenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie,
                                    DefaultAuthenticationTypes.ExternalCookie);
            return RedirectToAction("Index", "Home");
        }

        private IAuthenticationManager AuthenticationManager
        {
            get { return HttpContext.GetOwinContext().Authentication; }
        }
    }
}