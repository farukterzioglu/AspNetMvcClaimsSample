using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetMvcClaimsSample.WebApp.Models
{
    public enum UserType
    {
        User = 1,
        Operator = 2,
        Admin = 99,

    }

    public class UserDTO
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public int UserType { get; set; }
    }
}