using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lbl.Model.Student
{
    public class Entity
    {
        public string Id { get; set; }
        [Index]
        [Required]
        public DateTime Created { get; set; }
        [Index]
        [Required]
        [StringLength(50)]
        public string CreatedBy { get; set; }
        [Index]
        [Required]
        public DateTime Modified { get; set; }
        [Index]
        [Required]
        [StringLength(50)]
        public string ModifiedBy { get; set; }
    }
}