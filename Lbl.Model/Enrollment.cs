using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Lbl.Model.Student;

namespace Lbl.Model
{
    public class Enrollment : Entity
    {
        [Index]
        [MaxLength(128)]
        public string StudentId { get; set; }
        [Index]
        [MaxLength(128)]
        public string CourseId { get; set; }
        public bool IsPaid { get; set; }
        public double PaidTotal { get; set; }
        public double Due { get; set; }
        public bool IsCompleted { get; set; }
        public int CompletedContent { get; set; }
        [ForeignKey("StudentId")]
        public virtual Student.Student Student { set; get; }
        [ForeignKey("CourseId")]
        public virtual Course Course { set; get; }
    }
}
