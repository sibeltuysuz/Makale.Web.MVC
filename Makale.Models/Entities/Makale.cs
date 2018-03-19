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

        [Table("Makaleler")]
        public class Makale
        {
            [Key]
            public int MakaleId { get; set; }
            public int Onay { get; set; }
            [Required]
            [StringLength(200)]
            [Display(Name = "Başlık")]
            public string Baslik { get; set; }
            [Required]
            [StringLength(10000)]
            [Display(Name = "İçerik")]
            public string Icerik { get; set; }
            public int? Okunma { get; set; }
            public int? Begenme { get; set; }
            public DateTime Tarih { get; set; } = DateTime.Now;
            [StringLength(500)]
            [Display(Name = "Fotoğraf")]
            public string FotoUrl { get; set; }

            public int? KategoriId { get; set; }
            public string UyeId { get; set; }
            [ForeignKey("UyeId")]
            public virtual ApplicationUser Uye { get; set; }
            [ForeignKey("KategoriId")]
            public virtual Kategori Kategori { get; set; }
            public virtual List<Yorum> Yorumlar { get; set; } = new List<Yorum>();
        }
}
