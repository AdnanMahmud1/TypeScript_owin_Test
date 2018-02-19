using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Lbl.Model.Student;

namespace Lbl.Model
{
    public class Teacher:Entity
    {
        [Index]
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public string Address { get; set; }
        public string Designation { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}