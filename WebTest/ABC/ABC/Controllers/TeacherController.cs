using Microsoft.AspNetCore.Mvc;

namespace ABC.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
