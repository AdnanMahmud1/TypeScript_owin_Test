using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lbl.Model.Student
{
    public class Student : Entity
    {
        [Index]
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Address { get; set; }
        [Index]
        [Required]
        [StringLength(20)]
        public string Phone { set; get; }
        [Index]
        [StringLength(50)]
        public string Email { get; set; }
    }
}
