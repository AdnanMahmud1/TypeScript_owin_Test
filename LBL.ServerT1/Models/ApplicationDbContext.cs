using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace LBL.ServerT1.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<AspNetPermission> ApplicationPermissions { get; set; }
        public DbSet<AspNetResource> ApplicationResources { get; set; }

    }
}