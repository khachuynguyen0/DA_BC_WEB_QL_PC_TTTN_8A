using System.Diagnostics;
using ABC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ABC.Controllers
{
    /// <summary>
    /// Controller quản lý trang chủ và các chức năng chung
    /// </summary>
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        
        /// <summary>
        /// Constructor của HomeController
        /// </summary>
        /// <param name="logger">Logger để ghi log</param>
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        
        /// <summary>
        /// Hiển thị trang chủ
        /// </summary>
        /// <returns>View trang chủ với thông tin người dùng</returns>
        public IActionResult Index()
        {
            ViewBag.Username = "Giảng viên"; // Hoặc tên người dùng thực tế
            ViewBag.Role = "Admin"; // Hoặc vai trò thực tế
            _logger.LogInformation($"Username: {ViewBag.Username}, Role: {ViewBag.Role}"); // Dòng debug
            return View();
        }
        
        /// <summary>
        /// API tìm kiếm giảng viên theo mã
        /// </summary>
        /// <param name="code">Mã giảng viên</param>
        /// <returns>Thông tin giảng viên dạng JSON</returns>
        [HttpGet]
        public IActionResult SearchLecturer(string code)
        {
            // Xử lý tìm kiếm giảng viên
            // Hiện tại trả về dữ liệu mẫu
            var result = new { LecturerCode = code, Name = "John Doe", Subject = "Mathematics" };
            return Json(result);
        }
        
        /// <summary>
        /// Hiển thị trang chính sách bảo mật
        /// </summary>
        /// <returns>View trang chính sách bảo mật</returns>
        public IActionResult Privacy()
        {
            return View();
        }
        
        /// <summary>
        /// Xử lý đăng xuất và chuyển hướng đến trang đăng nhập
        /// </summary>
        /// <returns>Chuyển hướng đến trang đăng nhập</returns>
        public IActionResult Logout()
        {
            // Xử lý logic đăng xuất
            return RedirectToAction("Login", "Account");
        }
        
        /// <summary>
        /// Hiển thị trang lỗi
        /// </summary>
        /// <returns>View trang lỗi với thông tin lỗi</returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}