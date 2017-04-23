using AspNetMvcClaimsSample.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetMvcClaimsSample.WebApp.Services
{
    interface ILoginService
    {
        UserDTO GetUser(string userName, string password);
    }

    public class LoginService : ILoginService
    {
        public UserDTO GetUser(string userName, string password)
        {
            //TODO : Check user if exist 

            if (userName == "test")
                return new UserDTO()
                { 
                    Name = "Test User",
                    Id = 11,
                    UserName = "test",
                    UserType = (int)UserType.User
                };
            else if (userName == "admin")
                return new UserDTO()
                {
                    Name = "The Admin",
                    Id = 999,
                    UserName = "admin",
                    UserType = (int)UserType.Admin
                };
            else if (userName == "operator")
                return new UserDTO()
                {
                    Name = "The Operator",
                    Id = 37,
                    UserName = "operator",
                    UserType = (int)UserType.Operator
                };

            return null;
        }
    }
}