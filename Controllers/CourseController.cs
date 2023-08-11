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
        public IActionResult Apply()
        {
            return View();
        }
    }
}
