using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothShop.DTO
{
    [Table("SanPham")]
    public class SanPham
    {
        public SanPham()
        {
            this.CTSanPhams = new HashSet<CTSanPham>();
        }
        [Key]
        [StringLength(10)] 
        [Required]
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public int ID_NhomSP { get; set; }
        [ForeignKey("ID_NhomSP")]
        
        public virtual NhomSP NhomSP { get; set; }
        public double GiaBan { get; set; }
        public double KhuyenMai { get; set; }
        public virtual ICollection<CTSanPham> CTSanPhams { get; set; }
    }
}
