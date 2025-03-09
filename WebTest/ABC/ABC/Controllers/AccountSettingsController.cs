using Microsoft.AspNetCore.Mvc;

namespace ABC.Controllers
{
    /// <summary>
    /// Controller quản lý cài đặt tài khoản
    /// </summary>
    public class AccountSettingsController : Controller
    {
        /// <summary>
        /// Hiển thị trang cài đặt tài khoản
        /// </summary>
        public IActionResult Index()
        {
            return View();
        }
        
        /// <summary>
        /// Tạo cài đặt tài khoản mới
        /// </summary>
        [HttpPost]
        public IActionResult Create(string accountCode, string accountName, string password, string permissionCode)
        {
            // Xử lý tạo cài đặt tài khoản mới
            return RedirectToAction("Index");
        }
        
        /// <summary>
        /// Cập nhật cài đặt tài khoản hiện có
        /// </summary>
        [HttpPost]
        public IActionResult Edit(string accountCode, string accountName, string password, string permissionCode)
        {
            // Xử lý cập nhật cài đặt tài khoản
            return RedirectToAction("Index");
        }
    }
}