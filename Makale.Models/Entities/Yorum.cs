using Makale.Models.IdentityModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makale.Models.Entities
{
    [Table("Yorum")]
    public class Yorum
    {
        [Key]
        public int YorumId { get; set; }
        [Column(TypeName = "ntext")]
        public string YorumMetni { get; set; }
        public string AdSoyad { get; set; }
        public string Email { get; set; }
        public DateTime YorumTarihi { get; set; } = DateTime.Now;
        public int? MakaleId { get; set; }
        public string UyeId { get; set; }
        [ForeignKey("UyeId")]
        public virtual ApplicationUser Uye { get; set; }
        [ForeignKey("MakaleId")]
        public virtual Makale Makale { get; set; }
    }


   
}
