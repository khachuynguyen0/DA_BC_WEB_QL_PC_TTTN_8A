using Microsoft.AspNetCore.Mvc;

namespace ABC.Controllers
{
    /// <summary>
    /// Controller quản lý đề tài
    /// </summary>
    public class ProjectController : Controller
    {
        /// <summary>
        /// Hiển thị trang danh sách đề tài
        /// </summary>
        /// <returns>View danh sách đề tài</returns>
        public IActionResult Index()
        {
            return View();
        }
    }
}