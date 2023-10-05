using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothShop.DTO
{
    [Table("CTSanPham")]
    public class CTSanPham
    {
        public CTSanPham()
        {
            this.CTHoaDons = new HashSet<CTHoaDon>();
            this.CTNhapKho = new HashSet<CTNhapKho>();
        }
        [Key]
        [StringLength(20)]
        [Required]
        public string MaCTSP { get; set; }
        [StringLength(10)]
        [Required]
        public string MaSP { get; set; }
        [ForeignKey("MaSP")]
        public virtual SanPham SanPham { get; set; }
        public string Size { get; set; }
        public string MauSac { get; set; }
        public int SoLuong { get; set; }

        public virtual ICollection<CTHoaDon> CTHoaDons { get; set; }
        public virtual ICollection<CTNhapKho> CTNhapKho { get; set; }

    }
}
