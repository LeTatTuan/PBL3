using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothShop.DTO
{
    [Table("NhanVien")]
    public class NhanVien
    {
        public NhanVien()
        {

            this.NhapKhos = new HashSet<NhapKho>();
            this.HoaDons = new HashSet<HoaDon>();

        }
        [Key]
        [StringLength(10)]
        [Required]

        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string DiaChi { get; set; }
        public bool GioiTinh { get; set; }
        [Required]
        public string ChucVu { get; set; }
        [StringLength(10)]
        public string SDT { get; set; }
        [Required]
        [StringLength(10)]
        public string MatKhau { get; set; }

        public virtual ICollection<NhapKho> NhapKhos { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
