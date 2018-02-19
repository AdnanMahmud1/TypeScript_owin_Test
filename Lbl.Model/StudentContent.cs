using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Lbl.Model.Student;

namespace Lbl.Model
{
    public class StudentContent : Entity
    {
        [Index]
        [MaxLength(128)]
        public string StudentId { get; set; }
        [Index]
        [MaxLength(128)]
        public string ContentId { get; set; }
        public int WatchedContent { set; get; }
        [ForeignKey("StudentId")]
        public virtual Student.Student Student { set; get; }
        [ForeignKey("ContentId")]
        public virtual Content Content { set; get; }
    }
}
