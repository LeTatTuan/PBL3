using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothShop.DTO
{
    [Table("NhapKho")]
    public class NhapKho
    {
        public NhapKho()
        {
            CTNhapKhos = new HashSet<CTNhapKho>();
        }

        [Key]
        [StringLength(10)]
        [Required]
        public string MaNK { get; set; }
        [StringLength(10)]
        public string MaNCC { get; set; }
        [ForeignKey("MaNCC")]
        public virtual NhaCungCap NhaCungCap { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgaySua { get; set; }
        [StringLength(10)]
        public string ID_NguoiSua { get; set; }
        [ForeignKey("ID_NguoiSua")]
        public virtual NhanVien NguoiSua { get; set; }
        [StringLength(10)]
        public string ID_NguoiTao { get; set; }
        [ForeignKey("ID_NguoiTao")]
        public virtual NhanVien NguoiTao { get; set; }
        public virtual ICollection<CTNhapKho> CTNhapKhos { get; set; }
    }
}
