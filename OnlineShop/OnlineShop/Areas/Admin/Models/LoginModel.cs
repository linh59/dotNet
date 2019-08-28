using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShop.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Enter user name")]
        public string UserName { set; get; }
        [Required(ErrorMessage = "Enter Password")]
        public string Password { set; get; }
        public bool Remember { set; get; }
    }
}