using Microsoft.AspNetCore.Mvc;

namespace ABC.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
