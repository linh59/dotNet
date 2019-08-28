using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShop.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "User Name")]
        public string UserName { set; get; }
        [Required(ErrorMessage = "Password")]
        public string Password { set; get; }
        public bool RememberMe { set; get; }
    }
}