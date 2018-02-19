using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LBL.ServerT1.Models
{
    public enum ResourceType
    {
        WebPage = 1,
        Div = 2,
        UIControl = 3
    }
    public class AspNetResource : BaseEntity

    {   [Required]
        public string Name { get; set; }
        [Required]
        public ResourceType Type { get; set; }
        [Required]
        public bool IsPublic { get; set; }
        public virtual ICollection<AspNetPermission> ApplicationPermissions { set; get; }
    }
}