using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LBL.ServerT1.Models
{
    public class AspNetPermission:BaseEntity
    {

        [Index]
        [MaxLength(128)]
        public string RoleId { get; set; }

        [Index]
        [MaxLength(128)]
        public string ResourceId { get; set; }

        public bool IsAllowed { get; set; }
        public bool IsDisabled { get; set; }

        [ForeignKey("RoleId")]
        public virtual ApplicationRole ApplicationRole { get; set; }

        [ForeignKey("ResourceId")]
        public virtual AspNetResource Resource { get; set; }
    }
}