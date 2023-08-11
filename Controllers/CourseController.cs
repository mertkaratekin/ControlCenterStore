using ControlCenterX.Models;
using Microsoft.AspNetCore.Mvc;

namespace ControlCenterX.Controllers
{
    //Kurs işlemleri için Controller oluşturuldu. 
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
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
            Repository.Add(model);
            return Redirect("/");

        }
    }
}
