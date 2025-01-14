﻿using System.ComponentModel.DataAnnotations;

namespace baitap07.Models
{
    public class TheLoai
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Không được để trống tên thể loại")]
        [Display(Name="Thể Loại")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Không đúng định dạng ngày-tháng-năm")]
        [Display(Name = "Ngày tạo")]
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
