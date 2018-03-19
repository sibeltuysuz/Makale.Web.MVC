using Makale.Models.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Makale.Models.IdentityModels
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [StringLength(25)]
        public string Name { get; set; }
        [Required]
        [StringLength(25)]
        public string Surname { get; set; }
        public DateTime RegisterDate { get; set; } = DateTime.Now;
        public string ActivationCode { get; set; }

        public virtual List<Makale.Models.Entities.Makale> Makaleler { get; set; } = new List<Makale.Models.Entities.Makale>();
        public virtual List<Yorum> Yorumlar { get; set; } = new List<Yorum>();
    }
}