﻿using Microsoft.AspNetCore.Mvc;

namespace baitap04.Controllers
{
    public class TheLoaiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Edit(int id)
        {
            return Ok("id: " + id);
        }
        public IActionResult Detail(int id, string ten)
        {
            //return Content("Id: " + id +" ; ten: "+ ten);
            return Content(String.Format("id:{0}; ten:{1}", id, ten));
        }
        public IActionResult Show(List<string> categories)
        {
            //return Content("Id: " + id +" ; ten: "+ ten);
            string content = "Danh sách thể loại:";
            foreach (var category in categories)
            {
                content = content + " " + category + ",";
            }
            return Content(content);
        }
    }

}