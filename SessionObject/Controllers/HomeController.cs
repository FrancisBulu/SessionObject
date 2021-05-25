using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SessionObject.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace SessionObject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var userInfo = new UserInfo()
            {
                Id = 1,
                Name = "Franck"
            };
            HttpContext.Session.SetString("SessionUser", JsonConvert.SerializeObject(userInfo));
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
