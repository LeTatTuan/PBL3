using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothShop.DTO
{
    [Table("NhomSP")]

    public class NhomSP
    {
        public NhomSP()
        {
            this.SanPhams = new HashSet<SanPham>();
        }
        [Key]
        [Required]
        public int ID_NhomSP { get; set; }
        public string TenNhomSP { get; set; }
        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
