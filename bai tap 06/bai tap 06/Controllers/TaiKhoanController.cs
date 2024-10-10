using bai_tap_06.Models;
using Microsoft.AspNetCore.Mvc;

namespace bai_tap_06.Controllers
{
    public class TaiKhoanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DangKy(TaiKhoanViewModel taiKhoan)
        {if (taiKhoan != null && taiKhoan.Password != null && taiKhoan.Password.Length > 0)
            {
                taiKhoan.Password = taiKhoan.Password + "da_ma_hoa";
            }
            return View(taiKhoan);
        }
    }
}
