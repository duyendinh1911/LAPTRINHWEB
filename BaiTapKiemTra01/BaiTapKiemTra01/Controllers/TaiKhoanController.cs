using BaiTapKiemTra01.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace BaiTapKiemTra01.Controllers
{
    public class TaiKhoanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult DangKy(TaiKhoanViewModel taiKhoan)
        {
            if (ModelState.IsValid)
            {
                // Sau khi form được submit, hiển thị dữ liệu bằng Content
                return Content($"Tên tài khoản: {taiKhoan.Username}<br/>" +
                               $"Mật khẩu: {taiKhoan.Password}<br/>" +
                               $"Họ tên: {taiKhoan.Name}<br/>" +
                               $"Tuổi: {taiKhoan.Age}");
            }
            return View(taiKhoan);
        }
        public IActionResult DangNhap(SanPhamViewModel model)
        {
            var sanpham = new SanPhamViewModel()
            {
                TenSanPham = " Americano",
                GiaBan = 20000000, // 20 million VND
                AnhMoTa = "iced-americano.png"
            };

            return View(sanpham);
        }
    }

    
}

