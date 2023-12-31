﻿using ControlCenterX.Models;
using Microsoft.AspNetCore.Mvc;

namespace ControlCenterX.Controllers
{
    //Kurs işlemleri için Controller oluşturuldu. 
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            var model = Repository.Applications;
            return View(model);
        }
        [HttpGet] //Eğer bir şey yazılmazsa default httpget olarak tanınır.
        public IActionResult Apply()
        {
            return View();
        }
        [HttpPost] //Attribute
        [ValidateAntiForgeryToken] // Güvenlik için doğrulama işlemi yapar.
        public IActionResult Apply(Candidate model)
        {
            if (Repository.Applications.Any(c => c.Email.Equals(model.Email)))
            {
                ModelState.AddModelError("", "There is already an application.");
            }
            if (ModelState.IsValid)
            {
                Repository.Add(model);
                return View("feedback", model);
            }else
            return View();
        }
    }
}
