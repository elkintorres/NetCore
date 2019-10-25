using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FrontMVC.Models;
using FrontMVC.Filters;

namespace FrontMVC.Controllers
{
    [AuthorizationFilter]
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Wellcome()
        {
            return View();
        }

        [HttpGet]
        public IActionResult TestError()
        {
            throw new Exception();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Contact(Contact model)
        {
            if (!ModelState.IsValid)
                return View(model);

            return RedirectToAction("Acknowledgement");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(string code)
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Acknowledgement()
        {
            return View();
        }
    }
}
