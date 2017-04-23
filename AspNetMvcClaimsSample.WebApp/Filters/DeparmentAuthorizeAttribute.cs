using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace AspNetMvcClaimsSample.WebApp.Filters
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = true, AllowMultiple = true)]
    public class DeparmentAuthorizeAttribute : AuthorizeAttribute
    {
        /// <summary>
        /// Comma seperated department ids
        /// </summary>
        public string AuthorizedDepartments { get; set; }

        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            base.OnAuthorization(filterContext);
        }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            #region Check custom authorization
            var principal = (ClaimsPrincipal)Thread.CurrentPrincipal;

            var departmentId = principal.Claims
                .Where(c => c.Type == "departmentId")
                .Select(c => c.Value).FirstOrDefault();

            List<string> list = AuthorizedDepartments.Split(',').ToList();
            var found = list.FirstOrDefault(x => x == departmentId);

            if (
                departmentId == null || found == null
                ) return false;

            #endregion

            //Default authorization
            return base.AuthorizeCore(httpContext);
        }
    }
}