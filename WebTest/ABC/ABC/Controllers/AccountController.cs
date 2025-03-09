using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ABC.Controllers
{
    /// <summary>
    /// Controller xử lý các chức năng tài khoản người dùng như đăng nhập, đăng ký, đăng xuất và quên mật khẩu
    /// </summary>
    public class AccountController : Controller
    {
        /// <summary>
        /// Hiển thị trang đăng nhập
        /// </summary>
        /// <returns>View trang đăng nhập</returns>
        public IActionResult Login()
        {
            return View();
        }
        
        /// <summary>
        /// Hiển thị trang đăng ký
        /// </summary>
        /// <returns>View trang đăng ký</returns>
        public IActionResult Register()
        {
            return View();
        }
        
        /// <summary>
        /// Xử lý đăng xuất người dùng và chuyển hướng về trang đăng nhập
        /// </summary>
        /// <returns>Chuyển hướng đến trang đăng nhập</returns>
        [HttpPost]
        public IActionResult Logout()
        {
            // Xử lý logic đăng xuất ở đây (xóa cookie, session, v.v.)
            return RedirectToAction("Login", "Account"); // Chuyển hướng đến trang đăng nhập
        }
        
        /// <summary>
        /// Hiển thị trang quên mật khẩu
        /// </summary>
        /// <returns>View trang quên mật khẩu</returns>
        public IActionResult ForgotPassword()
        {
            return View();
        }
        
        /// <summary>
        /// Xử lý yêu cầu quên mật khẩu và gửi email đặt lại mật khẩu
        /// </summary>
        /// <param name="email">Địa chỉ email của người dùng</param>
        /// <returns>View trang quên mật khẩu với thông báo phù hợp</returns>
        [HttpPost]
        public async Task<IActionResult> ForgotPassword(string email)
        {
            // Kiểm tra email có hợp lệ không
            if (string.IsNullOrEmpty(email))
            {
                // Nếu email rỗng, hiển thị thông báo lỗi
                TempData["Error"] = "Vui lòng nhập email!";
                return View();
            }
            
            // TODO: Triển khai logic đặt lại mật khẩu tại đây
            // Ví dụ: Tạo token, lưu vào database, gửi email với link đặt lại mật khẩu
            await Task.Delay(1000); // Giả lập hoạt động bất đồng bộ (gửi email)
            
            // Hiển thị thông báo thành công
            TempData["Success"] = "Link đặt lại mật khẩu đã được gửi vào email của bạn!";
            return View();
        }
    }
}