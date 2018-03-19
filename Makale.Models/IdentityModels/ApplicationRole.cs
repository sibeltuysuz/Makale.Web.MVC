using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;

namespace Makale.Models.IdentityModels
{
    public class ApplicationRole : IdentityRole
    {
        [StringLength(200)]
        public string Description { get; set; }
    }
}
