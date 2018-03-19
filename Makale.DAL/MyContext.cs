using Makale.Models.Entities;
using Makale.Models.IdentityModels;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makale.DAL
{
    public class MyContext : IdentityDbContext<ApplicationUser>
    {
        public MyContext()
        : base("name=MyCon")
        {
        }
        public virtual DbSet<Makale.Models.Entities.Makale> Makaleler { get; set; }
        public virtual DbSet<Kategori> Kategoriler { get; set; }
        public virtual DbSet<Yorum> Yorumlar { get; set; }
    }
}
