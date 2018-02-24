using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Lbl.Model.Student;

namespace Lbl.IdentityModel
{
    public class Resource:Entity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public bool IsPublic { get; set; }
    }

    public class Permission : Entity
    {
        [Index]
        [MaxLength(128)]
        public string RoleId { get; set; }

        //[ForeignKey("RoleId")]
        //public virtual ApplicationRole ApplicationRole { get; set; }

        [Index]
        [MaxLength(128)]
        public string ResourceId { get; set; }

        [ForeignKey("ResourceId")]
        public virtual Resource Resource { get; set; }

        public bool IsAllowed { get; set; }

        public bool IsDisabled { get; set; }
    }
}
