using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makale.Models.Entities
{
    [Table("Kategoriler")]
    public class Kategori
    {
        [Key]
        [Display(Name = "Kategori Id")]
        public int KategoriId { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Kategori Adı alanı en fazla 20 karakter olabilir.")]
        [Display(Name = "Kategori Adı")]
        public string KategoriAdi { get; set; }
        public virtual List<Makale> Makaleler { get; set; } = new List<Makale>();
    }
}
