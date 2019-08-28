using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClassLibrary1.Dao;
using OnlineShop.Areas.Admin.Models;
using OnlineShop.Common;

namespace OnlineShop.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Users
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                var hash = Encrytor.MD5Hash(model.Password);
                var result = dao.Login(model.UserName, hash);
                if (result ==1)
                {
                    var user = dao.GetById(model.UserName);
                    var userSession = new UserLogincs();
                    userSession.Username = user.UserName;
                    userSession.UserID = user.ID;
                    Session.Add(CommonConstant.USER_SESSION,userSession );
                    return RedirectToAction("Index", "Home");
                }else if(result == 0){
                    ModelState.AddModelError("", "Accoutn is not define");
                }else if (result == -2)
                {
                    ModelState.AddModelError("", "Password is not correct");

                }
                else
                {
                    ModelState.AddModelError("", "something went wrong");
                }
            }return View("Index");
           
        }
    }
}