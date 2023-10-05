using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothShop.DTO
{
    [Table("NhaCungCap")]
    public class NhaCungCap
    {
        public NhaCungCap()
        {
            NhapKhos = new HashSet<NhapKho>();
        }

        [Key]
        [StringLength(10)]
        [Required]

        public string MaNCC { get; set; }
        public string TenNCC { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string Mail { get; set; }
        public virtual ICollection<NhapKho> NhapKhos { get; set; }
    }
}
