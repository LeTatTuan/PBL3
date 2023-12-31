﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothShop.DTO
{
    [Table("KhachHang")]
    public class KhachHang
    {
        [Key]
        [StringLength(10)]
        [Required]
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        [StringLength(10)]
        public string SDT { get; set; }
        public bool GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public DateTime NgaySinh { get; set; }

    }
}
