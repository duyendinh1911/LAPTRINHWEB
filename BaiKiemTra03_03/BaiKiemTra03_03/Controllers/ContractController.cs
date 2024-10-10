using BaiKiemTra03_03.Data;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Contracts;

namespace BaiKiemTra03_03.Controllers
{
    public class ContractController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ContractController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Hiển thị danh sách hợp đồng
        public IActionResult Index()
        {
            var contracts = _context.Contracts.ToList();
            ViewBag.contract = contracts;
            return View();
        }

        // Thêm hợp đồng
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Contract contract)
        {
            if (ModelState.IsValid)
            {
                _context.Contracts.Add(contract);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        // Sửa hợp đồng
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var contract = _context.Contracts.Find(id);
            if (contract == null)
            {
                return NotFound();
            }
            return View(contract);
        }

        [HttpPost]
        public IActionResult Edit(Contract contract)
        {
            if (ModelState.IsValid)
            {
                _context.Contracts.Update(contract);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(contract);
        }

        // Xóa hợp đồng
        [HttpGet]
        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var theloai = _context.Contracts.Find(id);
            return View(theloai);
        }
        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            var contract = _context.Contracts.Find(id);
            if (contract == null)
            {
                return NotFound();
            }
            _context.Contracts.Remove(contract);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var theloai = _context.Contracts.Find(id);

            return View(theloai);
        }
    }
}