using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SessionObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SessionObject.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            var user = JsonConvert.DeserializeObject<UserInfo>(HttpContext.Session.GetString("SessionUser"));
            user.Id = 50;
            user.Name = "Stylz";
            return View(user);
        }
    }
}
