﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Web_ThietBiGiaoDuc.Models
{
    public class LoaiSanPham
    {
        public LoaiSanPham() 
        {
            MaLoai= "L" + Guid.NewGuid().ToString("N").Substring(0, 8);
        }
        [Key]
        public string MaLoai { get; set; }
        public string TenLoai {  get; set; }
        public string TrangThai { get; set; }
        public string MaDM { get; set; }
        public virtual DanhMuc DanhMuc { get; set; }
        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}