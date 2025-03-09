using Microsoft.AspNetCore.Mvc;

namespace ABC.Controllers
{
    /// <summary>
    /// Controller quản lý người phụ trách
    /// </summary>
    public class ResponsiblePersonController : Controller
    {
        /// <summary>
        /// Hiển thị trang danh sách người phụ trách
        /// </summary>
        /// <returns>View danh sách người phụ trách</returns>
        public IActionResult Index()
        {
            return View();
        }
        
        /// <summary>
        /// Tạo người phụ trách mới
        /// </summary>
        /// <param name="responsiblePersonCode">Mã người phụ trách</param>
        /// <param name="name">Tên người phụ trách</param>
        /// <param name="position">Chức vụ</param>
        /// <param name="phoneNumber">Số điện thoại</param>
        /// <param name="email">Email</param>
        /// <param name="companyName">Tên công ty</param>
        /// <returns>Chuyển hướng về trang danh sách người phụ trách</returns>
        [HttpPost]
        public IActionResult Create(string responsiblePersonCode, string name, string position, string phoneNumber, string email, string companyName)
        {
            // Xử lý tạo người phụ trách mới
            return RedirectToAction("Index");
        }
        
        /// <summary>
        /// Cập nhật thông tin người phụ trách
        /// </summary>
        /// <param name="responsiblePersonCode">Mã người phụ trách</param>
        /// <param name="name">Tên người phụ trách</param>
        /// <param name="position">Chức vụ</param>
        /// <param name="phoneNumber">Số điện thoại</param>
        /// <param name="email">Email</param>
        /// <param name="companyName">Tên công ty</param>
        /// <returns>Chuyển hướng về trang danh sách người phụ trách</returns>
        [HttpPost]
        public IActionResult Edit(string responsiblePersonCode, string name, string position, string phoneNumber, string email, string companyName)
        {
            // Xử lý cập nhật thông tin người phụ trách
            return RedirectToAction("Index");
        }
    }
}