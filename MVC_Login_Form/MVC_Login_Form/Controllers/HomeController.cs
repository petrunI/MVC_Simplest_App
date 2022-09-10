using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_Login_Form.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Login_Form.Controllers
{
    
    public class HomeController : Controller
    {
        List<LoginModel> userList = new List<LoginModel>
        {
                new LoginModel{ Login ="vharbar", Password = "1234", Admin = true},
                new LoginModel{ Login ="ipetrunin", Password = "4321", Admin = false},
                new LoginModel{ Login ="konchilas", Password = "fantasia", Admin = true},
                new LoginModel{ Login ="user1", Password = "pass1", Admin = false}
        };

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Check(LoginModel model)
        {
           
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
