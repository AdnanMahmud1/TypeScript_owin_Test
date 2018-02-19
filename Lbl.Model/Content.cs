using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Lbl.Model.Student;

namespace Lbl.Model
{
    public class Content:Entity
    {
        public int  Serial { get; set; }
        [Index]
        [MaxLength(128)]
        public string CourseId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        [MaxLength(500)]
        public string Description { get; set; }
        [Required]
        [MaxLength(500)]
        public string Url { get; set; }
        public int TotalSeconds { set; get; }
        [Required]
        [MaxLength(100)]
        public string Tags { get; set; }
        public int  Category { get; set; }
        [ForeignKey("CourseId")]
        public virtual Course Course { set; get; }
    }
}
