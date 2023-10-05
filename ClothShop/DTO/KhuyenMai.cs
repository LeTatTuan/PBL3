using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothShop.DTO
{
    [Table("KhuyenMai")]
    public class KhuyenMai
    {

        public KhuyenMai()
        {
            this.HoaDons = new HashSet<HoaDon>();
        }
        [Key]
        [StringLength(10)]
        [Required]
        public string MaKM { get; set; }
        public string MoTa { get; set; }
        public double GiaTri { get; set; }
        public int HanSuDung { get; set; }
        public DateTime NgayApDung { get; set; }
        public string TenKM { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }

    }
}
