using Microsoft.AspNetCore.Mvc;

namespace ABC.Controllers
{
    public class CompanyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
