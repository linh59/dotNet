using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop
{
    [Serializable]
    public class UserLogincs
    {
        public long UserID { set; get; }
        public string Username { set; get; }
    }
}