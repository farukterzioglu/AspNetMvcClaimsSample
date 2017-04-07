using System.ComponentModel.DataAnnotations;

namespace AspNetMvcClaimsSample.WebApp.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "User name")]
        [DataType(DataType.Text)]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}