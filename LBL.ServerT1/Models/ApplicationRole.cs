using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNet.Identity.EntityFramework;

namespace LBL.ServerT1.Models
{
    public class ApplicationRole : IdentityRole
    {
        public ApplicationRole()
        { }
        public ApplicationRole(string name):base(name)
        {}
        [MaxLength(20)]
        public string LandingRoute { get; set; }
        [Index]
        [Required]
        public DateTime Created { get; set; }

        [Index]
        [Required]
        [MaxLength(50)]
        public string CreatedBy { get; set; }

        [Index]
        [Required]
        public DateTime Modified { get; set; }

        [Index]
        [Required]
        [MaxLength(50)]
        public string ModifiedBy { get; set; }

        public virtual ICollection<AspNetPermission> ApplicationPermissions { set; get; }
    }
}