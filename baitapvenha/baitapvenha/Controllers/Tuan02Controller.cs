using Microsoft.AspNetCore.Mvc;

namespace baitapvenha.Controllers
{
    public class Tuan02Controller : Controller
    {
        public IActionResult Index()
        {
            ViewBag.HoTen = "Đinh Thị Duyên";
            ViewBag.MSSV = "1822030767";
            ViewData["Nam"] = "Năm 2003";
            return View();
        }
        public IActionResult Index2()
        {

            return View();
        }
    }
}
