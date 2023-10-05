using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothShop.DTO
{
    public class CTNhapKho
    {
        [Key]
        [StringLength(20)]
        [Required]
        public string MaCTNK { get; set; }
        [StringLength(10)]
        public string MaNK { get; set; }
        [ForeignKey("MaNK")]
        public virtual NhapKho NhapKho { get; set; }
        [StringLength(10)]
        public string MaCTSP { get; set; }
        [ForeignKey("MaCTSP")]
        public virtual CTSanPham CTSanPham { get; set; }
        public int GiaNhap { get; set; }
        public int SoLuong { get; set; }
    }
}
