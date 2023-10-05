using ClothShop.View.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothShop.DTO
{
    [Table("HoaDon")]
    public class HoaDon
    {
        public HoaDon()
        {
            this.CTHoaDons = new HashSet<CTHoaDon>();
        }
        [Key]
        [StringLength(10)]
        [Required]
        public string MaHD { get; set; }
        [StringLength(10)]
        public string MaKM { get; set; }
        [ForeignKey("MaKM")]
        public virtual KhuyenMai KhuyenMai { get; set; }
        public double GiaTriKM { get; set; }
        [StringLength(10)]
        public string MaKH { get; set; }
        [ForeignKey("MaKH")]
        public virtual KhachHang KhachHang { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgaySua { get; set; }
        [StringLength(10)]
        public string ID_NguoiSua { get; set; }
        [ForeignKey("ID_NguoiSua")]
        public virtual NhanVien NguoiSua { get; set; }
        public string ID_NguoiTao { get; set; }
        [ForeignKey("ID_NguoiTao")]
        public virtual NhanVien NguoiTao { get; set; }

        public virtual ICollection<CTHoaDon> CTHoaDons { get; set; }

    }
}
