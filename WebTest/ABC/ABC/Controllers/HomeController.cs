using System.Diagnostics;
using ABC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ABC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

public IActionResult Index()
{
    return View();
}

[HttpGet]
public IActionResult SearchLecturer(string code)
{
    // Implement search logic here
    // For now, return a dummy response
    var result = new { LecturerCode = code, Name = "John Doe", Subject = "Mathematics" };
    return Json(result);
}


        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Logout()
        {
            // Implement logout logic here
            return RedirectToAction("Login", "Account");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
