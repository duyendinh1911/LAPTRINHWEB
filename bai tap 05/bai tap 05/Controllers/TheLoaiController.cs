using bai_tap_05.Models;
using Microsoft.AspNetCore.Mvc;

namespace bai_tap_05.Controllers
{
    public class TheLoaiController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Ngay = "Ngày 28";
            ViewBag.Thang = "Thang 02";
            ViewData["Nam"] = "Năm 2030";
            return View();
        }
        public IActionResult Index2()
        {
            var theloai = new TheLoaiViewModel
            {
                Id = 1,
                Name = "Trinh Thám"
            };
            return View(theloai);
        }
    }
}
