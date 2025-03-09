using Microsoft.AspNetCore.Mvc;

namespace ABC.Controllers
{
    /// <summary>
    /// Controller quản lý phiếu đánh giá
    /// </summary>
    public class EvaluationController : Controller
    {
        /// <summary>
        /// Hiển thị trang danh sách phiếu đánh giá
        /// </summary>
        /// <returns>View danh sách phiếu đánh giá</returns>
        public IActionResult Index()
        {
            return View();
        }
        
        /// <summary>
        /// Tạo phiếu đánh giá mới
        /// </summary>
        /// <param name="evaluationCode">Mã phiếu đánh giá</param>
        /// <param name="creationDate">Ngày tạo</param>
        /// <param name="comments">Nhận xét</param>
        /// <param name="teacherName">Tên giáo viên</param>
        /// <param name="studentName">Tên học sinh</param>
        /// <param name="averageScore">Điểm trung bình</param>
        /// <param name="classification">Xếp loại</param>
        /// <returns>Chuyển hướng về trang danh sách phiếu đánh giá</returns>
        [HttpPost]
        public IActionResult Create(string evaluationCode, DateTime creationDate, string comments, string teacherName, string studentName, double averageScore, string classification)
        {
            // Xử lý tạo phiếu đánh giá mới
            return RedirectToAction("Index");
        }
        
        /// <summary>
        /// Cập nhật phiếu đánh giá
        /// </summary>
        /// <param name="evaluationCode">Mã phiếu đánh giá</param>
        /// <param name="week">Tuần</param>
        /// <param name="creationDate">Ngày tạo</param>
        /// <param name="score">Điểm số</param>
        /// <param name="notes">Ghi chú</param>
        /// <returns>Chuyển hướng về trang danh sách phiếu đánh giá</returns>
        [HttpPost]
        public IActionResult Edit(string evaluationCode, int week, DateTime creationDate, double score, string notes)
        {
            // Xử lý cập nhật phiếu đánh giá
            return RedirectToAction("Index");
        }
    }
}