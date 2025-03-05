using Microsoft.AspNetCore.Mvc;

namespace ABC.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
