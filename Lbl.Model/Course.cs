using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Lbl.Model.Student;

namespace Lbl.Model
{
    //public enum LevelOfAudiance
    //{
    //    Begineer,
    //    Intermediate,
    //    Advance
    //}
    public class Course : Entity
    {
        [Index]
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Index]
        [Required]
        public double Price { set; get; }

        [Index]
        [Required]
        [MaxLength(100)]
        public string Tags { set; get; }
        [Required]
        public int TotalStudentEnrolled { get; set; }
        [Required]
        public DateTime PublishDate { set; get; }
        [Required]
        public int TotalLecturesCount { get; set; }
        //public double TotalHours { set; get; }
        //public LevelOfAudiance LevelOfAudiance { set; get; }
        [Required]
        [MaxLength(100)]
        public string SubTitle { get; set; }
        [MaxLength(150)]
        public string CourseSummary { get; set; }
        [MaxLength(250)]
        public string CourseShortDescription { get; set; }
        [MaxLength(50)]
        public string Language { get; set; }
        [MaxLength(50)]
        public string Achive { get; set; }
        [MaxLength(50)]
        public string Requirements { set; get; }
        [MaxLength(500)]
        public string FullDescription { get; set; }
        
        [Index]
        [MaxLength(128)]
        public string TeacherId { get; set; }
        [ForeignKey("TeacherId")]
        public virtual Teacher Teacher { set; get; }
    }
}