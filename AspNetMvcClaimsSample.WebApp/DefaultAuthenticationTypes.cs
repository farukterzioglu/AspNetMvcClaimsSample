#region Assembly Microsoft.AspNet.Identity.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// D:\Projects\Workout\MVC\CustomMvc\packages\Microsoft.AspNet.Identity.Core.2.2.1\lib\net45\Microsoft.AspNet.Identity.Core.dll
#endregion

namespace AspNetMvcClaimsSample.WebApp
{
    //
    // Summary:
    //     Default authentication types values
    public static class DefaultAuthenticationTypes
    {
        //
        // Summary:
        //     Default value for the main application cookie used by UseSignInCookies
        public const string ApplicationCookie = "ApplicationCookie";
        //
        // Summary:
        //     Default value used by the UseOAuthBearerTokens method
        public const string ExternalBearer = "ExternalBearer";
        //
        // Summary:
        //     Default value used for the ExternalSignInAuthenticationType configured by UseSignInCookies
        public const string ExternalCookie = "ExternalCookie";
        //
        // Summary:
        //     Default value for authentication type used for two factor partial sign in
        public const string TwoFactorCookie = "TwoFactorCookie";
        //
        // Summary:
        //     Default value for authentication type used for two factor remember browser
        public const string TwoFactorRememberBrowserCookie = "TwoFactorRememberBrowser";
    }
}