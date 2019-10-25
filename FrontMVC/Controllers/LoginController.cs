using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrontMVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FrontMVC.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {


        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(UserModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            if (model.UserName.Equals("Admin") && model.Password.Equals("1234567890"))
            {
                HttpContext.Session.SetString("Rol", "AdminRol");
            }
            else
            {
                HttpContext.Session.SetString("Rol", "UserRol");
            }

            return RedirectToAction("Wellcome", "Home");
        }
    }
}