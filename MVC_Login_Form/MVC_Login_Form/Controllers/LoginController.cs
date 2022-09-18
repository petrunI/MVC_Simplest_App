using Microsoft.AspNetCore.Mvc;
using MVC_Login_Form.Models;
using System.Collections.Generic;

namespace MVC_Login_Form.Controllers
{
    public class LoginController : Controller
    {
        List<LoginModel> userList = new List<LoginModel>
        {
                new LoginModel{ Login ="vharbar", Password = "1234", Admin = true},
                new LoginModel{ Login ="ipetrunin", Password = "4321", Admin = false},
                new LoginModel{ Login ="konchilas", Password = "fantasia", Admin = true},
                new LoginModel{ Login ="user1", Password = "pass1", Admin = false}
        };

        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Check(LoginModel model)
        {
            foreach (LoginModel user in userList)
            {
                if (model.Login == user.Login && model.Password == user.Password)
                {
                    return View(user);
                }
            }
            if (model.Login == null && model.Password == null)
                return Redirect("Login/");
            return View();
        }

    }
}
