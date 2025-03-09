using Microsoft.AspNetCore.Mvc;

namespace ABC.Controllers
{
    /// <summary>
    /// Controller quản lý khoa
    /// </summary>
    public class DepartmentController : Controller
    {
        /// <summary>
        /// Hiển thị trang danh sách khoa
        /// </summary>
        /// <returns>View danh sách khoa</returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Tạo khoa mới
        /// </summary>
        /// <param name="departmentCode">Mã khoa</param>
        /// <param name="departmentName">Tên khoa</param>
        /// <returns>Chuyển hướng về trang danh sách khoa</returns>
        [HttpPost]
        public IActionResult Create(string departmentCode, string departmentName)
        {
            // Xử lý tạo khoa mới
            return RedirectToAction("Index");
        }

        /// <summary>
        /// Cập nhật thông tin khoa
        /// </summary>
        /// <param name="departmentCode">Mã khoa</param>
        /// <param name="departmentName">Tên khoa</param>
        /// <returns>Chuyển hướng về trang danh sách khoa</returns>
        [HttpPost]
        public IActionResult Edit(string departmentCode, string departmentName)
        {
            // Xử lý cập nhật thông tin khoa
            return RedirectToAction("Index");
        }
    }
}