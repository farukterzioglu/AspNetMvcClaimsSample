# Asp.Net MVC application with claims imlemented minimally. 

OWIN packages added.
	Microsoft.Owin
	Microsoft.Owin.Host.SystemWeb
	Microsoft.Owin.Security
	Microsoft.Owin.Security.Cookies

OWIN configured in "AspNetMvcClaimsSample.WebApp.Startup"

Default IIS authentication turned off
  <system.web>
    <authentication mode="None" />
  </system.web>
  <system.webServer>
    <modules>
      <remove name="FormsAuthentication" />
    </modules>
  </system.webServer>

A simple fake LoginService implemented. 
	"AspNetMvcClaimsSample.WebApp.Services.LoginService"

Simple login page implemented
	"AspNetMvcClaimsSample.WebApp.Controllers.AccountController"
	Claims used in account controller

An authorized page implemented, [Authorize] attribute added
	"AspNetMvcClaimsSample.WebApp.Controllers.AnAuthorizedController"

User type "Operator" added to test "Roles"

Login service extended for operator logins

"Roles" based controllers added;
	"Admin" controller and "CustomPages" controller added, decorated with [Authorize(Roles="[]")]


