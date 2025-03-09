using Microsoft.AspNetCore.Mvc;

namespace ABC.Controllers
{
    /// <summary>
    /// Controller quản lý thông tin công ty
    /// </summary>
    public class CompanyController : Controller
    {
        /// <summary>
        /// Hiển thị trang danh sách công ty
        /// </summary>
        /// <returns>View danh sách công ty</returns>
        public IActionResult Index()
        {
            return View();
        }
    }
}