using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ABC.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Logout()
        {
            // Implement logout logic here
            return RedirectToAction("Index", "Home");
        }

        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ForgotPassword(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                TempData["Error"] = "Vui lòng nhập email!";
                return View();
            }

            // TODO: Implement password reset logic here
            await Task.Delay(1000); // Simulate an asynchronous operation
            TempData["Success"] = "Link đặt lại mật khẩu đã được gửi vào email của bạn!";
            return View();
        }
    }
}
