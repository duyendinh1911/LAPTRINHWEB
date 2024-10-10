using Microsoft.AspNetCore.Mvc;

namespace baitapvenha.Controllers
{
    public class MayTinhController : Controller
    {
        public IActionResult MayTinh(double a = 0, double b = 0, string pheptinh = "cong")
        {
           
{
    double ketqua = 0;

    switch (pheptinh.ToLower())
    {
        case "cong":
            ketqua = a + b;
            break;
        case "tru":
            ketqua = a - b;
            break;
        case "nhan":
            ketqua = a * b;
            break;
        case "chia":
            if (b != 0)
            {
                ketqua = a / b;
            }
            else
            {
                ViewBag.Error = "Không thể chia cho 0";
            }
            break;
        default:
            ViewBag.Error = "Phép tính không hợp lệ";
            break;
    }

    if (ViewBag.Error == null)
    {
        ViewBag.KetQua = ketqua;
    }

    return View();
}
            
        }
    }
}
